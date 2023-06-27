using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FoodOrderingSystem.Configuration;

namespace FoodOrderingSystem.Web.Host.Startup
{
    [DependsOn(
       typeof(FoodOrderingSystemWebCoreModule))]
    public class FoodOrderingSystemWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public FoodOrderingSystemWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FoodOrderingSystemWebHostModule).GetAssembly());
        }
    }
}
