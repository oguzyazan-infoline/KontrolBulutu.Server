using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace KontrolBulutu.Server.Web
{
    [Dependency(ReplaceServices = true)]
    public class ServerBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Server";
    }
}
