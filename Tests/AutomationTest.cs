using NUnit.Framework;
using System.Threading;

namespace BMS_AutomationTest.Tests
{
    public class AutomationTest
    {
        string username;
        string password;
        public AutomationTest()
        {

        }
        [SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            username = "test@123";
            password = "test123";
        }

        [Test]
        public void ApplyRegisterAndLoginTest()
        {
            //string username = "test@12";
            //string password = "test123";

            NavigateTo.NavigateToRegisterPageThroughtRegisterLink();

            Thread.Sleep(2000);

            Actions.FillRegisterForm(username, password);

            Thread.Sleep(5000);

            var result = Actions.RegistrationSuccessIsDisplayed();

            Assert.True(result);

            NavigateTo.NavigateToLoginPageThroughHeader();

            Actions.FillLoginForm(username, password);

            Thread.Sleep(3000);

            Assert.AreEqual("http://localhost:4200/customer-dashboard", Driver.driver.Url);

        }

        [Test]
        public void PersonalLoanApplyTest()
        {
            //string username = "test@12";
            //string password = "test123";

            Actions.FillLoginForm(username, password);
            
            Thread.Sleep(3000);

            NavigateTo.NavigateToApplyLoanThroughButton();

            var result=Actions.FillPersonalLoan();
            Assert.True(result);

            NavigateTo.NavigateToViewLoanDetailsFromApplyLoanHeader();
            Thread.Sleep(3000);
            Assert.AreEqual("http://localhost:4200/loan-details", Driver.driver.Url);
        }

        [Test]
        public void EducationLoanApplyTest()
        {
            //string username = "test@12";
            //string password = "test123";

            Actions.FillLoginForm(username, password);

            Thread.Sleep(3000);

            NavigateTo.NavigateToApplyLoanThroughButton();

            var result = Actions.FillEducationLoan();
            Assert.True(result);

            NavigateTo.NavigateToViewLoanDetailsFromApplyLoanHeader();
            Thread.Sleep(3000);
            Assert.AreEqual("http://localhost:4200/loan-details", Driver.driver.Url);
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
