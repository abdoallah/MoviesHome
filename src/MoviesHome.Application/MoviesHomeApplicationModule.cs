using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MoviesHome.Authorization;

namespace MoviesHome
{
    [DependsOn(
        typeof(MoviesHomeCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MoviesHomeApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MoviesHomeAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MoviesHomeApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
