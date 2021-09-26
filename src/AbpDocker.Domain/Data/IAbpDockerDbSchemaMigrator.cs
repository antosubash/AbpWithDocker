using System.Threading.Tasks;

namespace AbpDocker.Data
{
    public interface IAbpDockerDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
