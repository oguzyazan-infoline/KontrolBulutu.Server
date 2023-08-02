using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace KontrolBulutu.Server.Web.Pages
{
    public class IndexModel : ServerPageModel
    {
        public void OnGet()
        {

        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}