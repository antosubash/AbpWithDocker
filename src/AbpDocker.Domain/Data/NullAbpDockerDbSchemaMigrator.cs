using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpDocker.Data
{
    /* This is used if database provider does't define
     * IAbpDockerDbSchemaMigrator implementation.
     */
    public class NullAbpDockerDbSchemaMigrator : IAbpDockerDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}