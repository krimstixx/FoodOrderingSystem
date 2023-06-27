using System.Threading.Tasks;
using FoodOrderingSystem.Models.TokenAuth;
using FoodOrderingSystem.Web.Controllers;
using Shouldly;
using Xunit;

namespace FoodOrderingSystem.Web.Tests.Controllers
{
    public class HomeController_Tests: FoodOrderingSystemWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}