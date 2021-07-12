using OpenQA.Selenium;
using System.Threading;

namespace BMS_AutomationTest.Pages
{
    public class ApplyLoan
    {
        public IWebElement HeaderViewLoanDetails;
        public IWebElement LoanTypeInput;
        public IWebElement LoanTypePersonal;
        public IWebElement LoanTypeEduaction;
        public IWebElement LoanAmountInput;
        public IWebElement LoanApplyDateInput;
        public IWebElement LoanIssueDateInput;
        public IWebElement DurationOfLoan5Input;
        public IWebElement DurationOfLoan10Input;
        public IWebElement DurationOfLoan15Input;
        public IWebElement DurationOfLoan20Input;
        public IWebElement AnnualIncomeInput;
        public IWebElement CompanyNameInput;
        public IWebElement DesignationInput;
        public IWebElement TotalExperienceInput;
        public IWebElement TotalExperienceInCurrentCompanyInput;

        public IWebElement CourseFeeInput;
        public IWebElement CourseInput;
        public IWebElement FatherNameInput;
        public IWebElement FatherOccupationInput;
        public IWebElement FatherExperienceInput;
        public IWebElement FatherExperienceInCurrentCompanyInput;
        public IWebElement RationCardInput;

        public IWebElement PersonalLoanButton;
        public IWebElement EducationLoanButton;

        public IWebElement LoanApplySuccess;

        public ApplyLoan()
        {
            LoanTypeInput = Driver.driver.FindElement(By.Id("loanType"));
            HeaderViewLoanDetails= Driver.driver.FindElement(By.CssSelector("#myNavbar > ul > li:nth-child(4) > a"));
        }
        
        public void ApplyPersonalLoan()
        {
            LoanTypePersonal = Driver.driver.FindElement(By.CssSelector("#loanType > option:nth-child(2)"));
            LoanTypePersonal.Click();
            Thread.Sleep(1000);

            LoanAmountInput = Driver.driver.FindElement(By.Id("amount"));
            LoanApplyDateInput = Driver.driver.FindElement(By.Id("loanApplyDate"));
            LoanIssueDateInput = Driver.driver.FindElement(By.Id("loanIssueDate"));
            DurationOfLoan5Input = Driver.driver.FindElement(By.CssSelector("#durationOfLoan > option:nth-child(1)"));
            DurationOfLoan10Input = Driver.driver.FindElement(By.CssSelector("#durationOfLoan > option:nth-child(2)"));
            DurationOfLoan15Input = Driver.driver.FindElement(By.CssSelector("#durationOfLoan > option:nth-child(3)"));
            DurationOfLoan20Input = Driver.driver.FindElement(By.CssSelector("#durationOfLoan > option:nth-child(4)"));
            AnnualIncomeInput = Driver.driver.FindElement(By.Id("annualIncome"));
            CompanyNameInput = Driver.driver.FindElement(By.Id("companyName"));
            DesignationInput = Driver.driver.FindElement(By.Id("designation"));
            TotalExperienceInput = Driver.driver.FindElement(By.Id("totalExperience"));
            TotalExperienceInCurrentCompanyInput = Driver.driver.FindElement(By.Id("experienceWithCurrentCompany"));

        }
        public void ClickPersoanlLoanApplyButton()
        {
            PersonalLoanButton = Driver.driver.FindElement(By.CssSelector("#applyPersonalLoanForm > div > div.row > div > button"));
            PersonalLoanButton.Click();
        }
        public void ApplyEducationLoan()
        {
            LoanTypeEduaction = Driver.driver.FindElement(By.CssSelector("#loanType > option:nth-child(3)"));
            LoanTypeEduaction.Click();

            Thread.Sleep(1000);

            LoanAmountInput = Driver.driver.FindElement(By.Id("amount"));
            LoanApplyDateInput = Driver.driver.FindElement(By.Id("loanApplyDate"));
            LoanIssueDateInput = Driver.driver.FindElement(By.Id("loanIssueDate"));
            DurationOfLoan5Input = Driver.driver.FindElement(By.CssSelector("#durationOfLoan > option:nth-child(1)"));
            DurationOfLoan10Input = Driver.driver.FindElement(By.CssSelector("#durationOfLoan > option:nth-child(2)"));
            DurationOfLoan15Input = Driver.driver.FindElement(By.CssSelector("#durationOfLoan > option:nth-child(3)"));
            DurationOfLoan20Input = Driver.driver.FindElement(By.CssSelector("#durationOfLoan > option:nth-child(4)"));
            AnnualIncomeInput = Driver.driver.FindElement(By.Id("annualIncome"));
            CourseFeeInput = Driver.driver.FindElement(By.Id("courseFee"));
            CourseInput = Driver.driver.FindElement(By.Id("course"));
            FatherNameInput = Driver.driver.FindElement(By.Id("fatherName"));
            FatherOccupationInput = Driver.driver.FindElement(By.Id("fatherOccupation"));
            FatherExperienceInput = Driver.driver.FindElement(By.Id("fatherTotalExperience"));
            FatherExperienceInCurrentCompanyInput = Driver.driver.FindElement(By.Id("fatherExperienceInCurrentCompany"));
            RationCardInput = Driver.driver.FindElement(By.Id("rationCardNumber"));
        }

        public void ClickEducationlLoanApplyButton()
        {
            EducationLoanButton = Driver.driver.FindElement(By.CssSelector("#applyEducationLoanForm > div > div.row > div > button"));
            EducationLoanButton.Click();
        }

        public bool LoanSuccessDisplayed()
        {
            LoanApplySuccess = Driver.driver.FindElement(By.Id("LoanSuccess"));
            return LoanApplySuccess.Displayed;
        }
    }
}
