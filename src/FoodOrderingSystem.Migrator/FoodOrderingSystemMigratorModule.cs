using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FoodOrderingSystem.Configuration;
using FoodOrderingSystem.EntityFrameworkCore;
using FoodOrderingSystem.Migrator.DependencyInjection;

namespace FoodOrderingSystem.Migrator
{
    [DependsOn(typeof(FoodOrderingSystemEntityFrameworkModule))]
    public class FoodOrderingSystemMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public FoodOrderingSystemMigratorModule(FoodOrderingSystemEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(FoodOrderingSystemMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                FoodOrderingSystemConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FoodOrderingSystemMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
