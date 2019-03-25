using System.Threading.Tasks;
using BoilerPlateExample.Web.Controllers;
using Shouldly;
using Xunit;

namespace BoilerPlateExample.Web.Tests.Controllers
{
    public class HomeController_Tests: BoilerPlateExampleWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
