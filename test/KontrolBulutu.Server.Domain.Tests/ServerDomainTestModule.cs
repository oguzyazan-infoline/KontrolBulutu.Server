using KontrolBulutu.Server.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace KontrolBulutu.Server
{
    [DependsOn(
        typeof(ServerEntityFrameworkCoreTestModule)
        )]
    public class ServerDomainTestModule : AbpModule
    {

    }
}