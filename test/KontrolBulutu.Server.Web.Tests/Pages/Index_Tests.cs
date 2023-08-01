using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace KontrolBulutu.Server.Pages
{
    public class Index_Tests : ServerWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
