using System.Threading.Tasks;

namespace KontrolBulutu.Server.Data
{
    public interface IServerDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
