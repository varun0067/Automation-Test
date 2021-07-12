using BMS_AutomationTest.Pages;

namespace BMS_AutomationTest
{
    public static class NavigateTo
    {
        public static void NavigateToRegisterPageThroughtRegisterLink()
        {
            LoginPage loginPage = new LoginPage();

            var link = loginPage.GetRegisterLink();
            link.Click();
        }

        public static void NavigateToRegisterPageThroughtHeader()
        {
            LoginPage loginPage = new LoginPage();

            var link=loginPage.GetRegisterLinkFromHeader();
            link.Click();
        }

        public static void NavigateToLoginPageThroughHeader()
        {
            RegisterPage registerPage = new RegisterPage();

            registerPage.LoginLink.Click();
        }

        public static void NavigateToApplyLoanThroughButton()
        {
            HomePage homePage = new HomePage();
            homePage.ButtonApplyLoan.Click();
        }

        public static void NavigateToViewLoanDetailsFromApplyLoanHeader()
        {
            ApplyLoan applyLoan = new ApplyLoan();
            applyLoan.HeaderViewLoanDetails.Click();
        }
    }
}
