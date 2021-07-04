using NUnit.Framework;
using System.Threading;

namespace BMS_AutomationTest.Tests
{
    public class LoanTest
    {
        public LoanTest()
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

            Actions.FillLoginForm(username, password);
            
            Thread.Sleep(2000);

            NavigateTo.NavigateToApplyLoanThroughButton();

            Thread.Sleep(3000);

            Assert.AreEqual("http://localhost:4200/apply-loan", Driver.driver.Url);
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
