using BMS_AutomationTest.Pages;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace BMS_AutomationTest
{
    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl("http://localhost:4200/");
        }

        public static void FillLoginForm(string username, string password)
        {
            LoginPage loginPage = new LoginPage();

            loginPage.UsernameInput.SendKeys(username);
            loginPage.PasswordInput.SendKeys(password);

            Thread.Sleep(2000);

            loginPage.ClickLogin();

        }

        public static string InvalidResposeLoginPage()
        {
            LoginPage loginPage = new LoginPage();
            return loginPage.GetInvalidResponse();
        }

        public static void FillRegisterForm(string username,string password)
        {
            RegisterPage registerPage = new RegisterPage();

            registerPage.NameInput.SendKeys("test");
            registerPage.EmailInput.SendKeys("test@gmail.com");
            registerPage.ContactNumberInput.SendKeys("8896547896");
            registerPage.UsernameInput.SendKeys(username);
            registerPage.PasswordInput.SendKeys(password);
            registerPage.GenderMaleInput.Click();
            registerPage.DateOfInput.SendKeys("15-08-1963");
            registerPage.MaritalStatusMarriedInput.Click();
            registerPage.GuardianTypeFatherInput.Click();
            registerPage.GuardianNameInput.SendKeys("Test");
            registerPage.AddressInput.SendKeys("Test Address");
            registerPage.CitizenshipIndianInput.Click();
            registerPage.CountryInput.Click();
            registerPage.State1Input.Click();
            registerPage.AccountTypeSavingsInput.Click();
            registerPage.BranchName1Input.Click();
            registerPage.IdentificationTypeAadharInput.Click();
            Thread.Sleep(2000);
            registerPage.FillIdentificationNumber();
            registerPage.NomineeNameInput.SendKeys("Test nominee");
            registerPage.NomineeAccountNumberInput.SendKeys("1234567891234568");
            registerPage.NomineeAddressInput.SendKeys("Nominee Address");

            Thread.Sleep(7000);

            registerPage.ClickRegisterButton();
        }

        public static bool RegistrationSuccessIsDisplayed()
        {
            RegisterPage registerPage = new RegisterPage();

            return registerPage.RegisterSuccessIsDisplayed();
        }

    }
}
