using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FoodOrderingSystem.Authorization;

namespace FoodOrderingSystem
{
    [DependsOn(
        typeof(FoodOrderingSystemCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class FoodOrderingSystemApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<FoodOrderingSystemAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(FoodOrderingSystemApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
