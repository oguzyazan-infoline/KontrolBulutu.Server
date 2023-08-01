using KontrolBulutu.Server.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace KontrolBulutu.Server.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class ServerPageModel : AbpPageModel
    {
        protected ServerPageModel()
        {
            LocalizationResourceType = typeof(ServerResource);
        }
    }
}