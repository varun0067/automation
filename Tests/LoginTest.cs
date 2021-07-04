using NUnit.Framework;
using System.Threading;

namespace BMS_AutomationTest.Tests
{
    public class LoginTest
    {
        public LoginTest()
        {

        }

        [SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void RegisterLoginTest()
        {
            string username = "test@12";
            string password = "test123";

            NavigateTo.NavigateToRegisterPageThroughtRegisterLink();

            Thread.Sleep(2000);

            Actions.FillRegisterForm(username,password);

            Thread.Sleep(5000);

            var result = Actions.RegistrationSuccessIsDisplayed();

            Assert.True(result);

            NavigateTo.NavigateToLoginPageThroughHeader();

            Actions.FillLoginForm(username, password);

            Thread.Sleep(3000);
            
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
