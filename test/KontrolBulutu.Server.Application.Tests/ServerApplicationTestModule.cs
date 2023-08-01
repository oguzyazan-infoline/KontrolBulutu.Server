using Volo.Abp.Modularity;

namespace KontrolBulutu.Server
{
    [DependsOn(
        typeof(ServerApplicationModule),
        typeof(ServerDomainTestModule)
        )]
    public class ServerApplicationTestModule : AbpModule
    {

    }
}