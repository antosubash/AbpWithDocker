using AbpDocker.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpDocker
{
    [DependsOn(
        typeof(AbpDockerEntityFrameworkCoreTestModule)
        )]
    public class AbpDockerDomainTestModule : AbpModule
    {

    }
}