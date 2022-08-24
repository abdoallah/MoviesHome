using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MoviesHome.Configuration;

namespace MoviesHome.Web.Host.Startup
{
    [DependsOn(
       typeof(MoviesHomeWebCoreModule))]
    public class MoviesHomeWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MoviesHomeWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MoviesHomeWebHostModule).GetAssembly());
        }
    }
}
