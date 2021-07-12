using OpenQA.Selenium;

namespace BMS_AutomationTest.Pages
{
    public class HomePage
    {
        public IWebElement HeaderApplyLoan;
        public IWebElement HeaderUpdateAccountDetails;
        public IWebElement HeaderViewLoanDetails;
        public IWebElement ButtonApplyLoan;
        public IWebElement ButtonUpdateAccount;
        public IWebElement ButtonViewLoanDetails;

        public HomePage()
        {
            HeaderApplyLoan = Driver.driver.FindElement(By.CssSelector("#myNavbar > ul > li:nth-child(1) > a"));
            HeaderUpdateAccountDetails = Driver.driver.FindElement(By.CssSelector("#myNavbar > ul > li:nth-child(2) > a"));
            HeaderViewLoanDetails = Driver.driver.FindElement(By.CssSelector("#myNavbar > ul > li:nth-child(4) > a"));

            ButtonApplyLoan = Driver.driver.FindElement(By.CssSelector("body > div:nth-child(2) > div > div > div > div:nth-child(1) > button"));
            ButtonUpdateAccount = Driver.driver.FindElement(By.CssSelector("body > div:nth-child(2) > div > div > div > div:nth-child(2) > button"));
            ButtonViewLoanDetails = Driver.driver.FindElement(By.CssSelector("body > div:nth-child(2) > div > div > div > div:nth-child(3) > button"));

        }
    }
}
