using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Study.Authorization;

namespace Study
{
    [DependsOn(
        typeof(StudyCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class StudyApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<StudyAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(StudyApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
