using OpenQA.Selenium;
using System.Threading;

namespace BMS_AutomationTest.Pages
{
    public class ApplyLoan
    {
        public IWebElement LoanTypeInput;
        public IWebElement LoanTypePersonal;
        public IWebElement LoanTypeEduaction;
        public IWebElement LoanAmountInput;
        public IWebElement LoanApplyDateInput;
        public IWebElement LoanIssueDateInput;
        public IWebElement DurationOfLoanInput;
        public IWebElement AnnualIncomeInput;
        public IWebElement CompanyNameInput;
        public IWebElement DesignationInput;
        public IWebElement TotalExperienceInput;
        public IWebElement TotalExperienceInCurrentCompanyInput;

        public ApplyLoan()
        {
            LoanTypeInput = Driver.driver.FindElement(By.CssSelector("body > div:nth-child(2) > div > div > div > div:nth-child(1) > button"));
            LoanTypeInput.GetAttribute("value");
        }
        
        public void ApplyPersonalLoan()
        {
            LoanTypePersonal = Driver.driver.FindElement(By.CssSelector("#loanType > option:nth-child(2)"));
            LoanTypePersonal.Click();
            Thread.Sleep(1000);

            LoanAmountInput = Driver.driver.FindElement(By.Id("amount"));
            LoanApplyDateInput = Driver.driver.FindElement(By.Id("loanApplyDate"));
            LoanIssueDateInput = Driver.driver.FindElement(By.Id("loanIssueDate"));
            DurationOfLoanInput = Driver.driver.FindElement(By.Id(""));
            AnnualIncomeInput = Driver.driver.FindElement(By.Id("annualIncome"));
            CompanyNameInput = Driver.driver.FindElement(By.Id(""));
            DesignationInput = Driver.driver.FindElement(By.Id(""));
            TotalExperienceInput = Driver.driver.FindElement(By.Id(""));
            TotalExperienceInCurrentCompanyInput = Driver.driver.FindElement(By.Id(""));

        }
        public void ApplyEducationLoan()
        {
            LoanTypeEduaction = Driver.driver.FindElement(By.CssSelector("#loanType > option:nth-child(3)"));
            LoanTypeEduaction.Click();
        }
    }
}
