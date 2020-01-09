using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using gimc.Authorization;

namespace gimc
{
    [DependsOn(
        typeof(gimcCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class gimcApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<gimcAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(gimcApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
