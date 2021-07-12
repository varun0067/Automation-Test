using BMS_AutomationTest.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
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

        public static bool FillPersonalLoan()
        {
            ApplyLoan applyLoan = new ApplyLoan();

            applyLoan.ApplyPersonalLoan();
            Thread.Sleep(1000);

            applyLoan.LoanAmountInput.SendKeys("90000");
            applyLoan.LoanApplyDateInput.SendKeys("04-07-2021");
            applyLoan.LoanIssueDateInput.SendKeys("24-07-2021");
            applyLoan.DurationOfLoan5Input.Click();
            applyLoan.AnnualIncomeInput.SendKeys("550000");
            applyLoan.CompanyNameInput.SendKeys("Test");
            applyLoan.DesignationInput.SendKeys("test@test");
            applyLoan.TotalExperienceInput.SendKeys("20");
            applyLoan.TotalExperienceInCurrentCompanyInput.SendKeys("10");

            Thread.Sleep(3000);

            applyLoan.ClickPersoanlLoanApplyButton();

            Thread.Sleep(2000);
            return applyLoan.LoanSuccessDisplayed();

        }
        public static bool FillEducationLoan()
        {
            ApplyLoan applyLoan = new ApplyLoan();

            applyLoan.ApplyEducationLoan();
            Thread.Sleep(1000);

            applyLoan.LoanAmountInput.SendKeys("90000");
            applyLoan.LoanApplyDateInput.SendKeys("04-07-2021");
            applyLoan.LoanIssueDateInput.SendKeys("24-07-2021");
            applyLoan.DurationOfLoan5Input.Click();
            applyLoan.AnnualIncomeInput.SendKeys("550000");
            applyLoan.CourseFeeInput.SendKeys("85000");
            applyLoan.CourseInput.SendKeys("test@test");
            applyLoan.FatherNameInput.SendKeys("test");
            applyLoan.FatherOccupationInput.SendKeys("test");
            applyLoan.FatherExperienceInput.SendKeys("10");
            applyLoan.FatherExperienceInCurrentCompanyInput.SendKeys("5");
            applyLoan.RationCardInput.SendKeys("123456");


            Thread.Sleep(3000);

            applyLoan.ClickEducationlLoanApplyButton();

            Thread.Sleep(2000);
            return applyLoan.LoanSuccessDisplayed();

        }

    }
}
