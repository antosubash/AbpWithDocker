using Volo.Abp.Modularity;

namespace AbpDocker
{
    [DependsOn(
        typeof(AbpDockerApplicationModule),
        typeof(AbpDockerDomainTestModule)
        )]
    public class AbpDockerApplicationTestModule : AbpModule
    {

    }
}