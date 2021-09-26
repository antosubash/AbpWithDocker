using AbpDocker.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpDocker.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpDockerEntityFrameworkCoreModule),
        typeof(AbpDockerApplicationContractsModule)
        )]
    public class AbpDockerDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
