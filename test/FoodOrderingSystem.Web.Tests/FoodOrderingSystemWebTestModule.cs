using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FoodOrderingSystem.EntityFrameworkCore;
using FoodOrderingSystem.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace FoodOrderingSystem.Web.Tests
{
    [DependsOn(
        typeof(FoodOrderingSystemWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class FoodOrderingSystemWebTestModule : AbpModule
    {
        public FoodOrderingSystemWebTestModule(FoodOrderingSystemEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FoodOrderingSystemWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(FoodOrderingSystemWebMvcModule).Assembly);
        }
    }
}