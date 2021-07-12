using OpenQA.Selenium;

namespace BMS_AutomationTest.Pages
{
    public class RegisterPage
    {
        public IWebElement NameInput;
        public IWebElement EmailInput;
        public IWebElement ContactNumberInput;
        public IWebElement UsernameInput;
        public IWebElement PasswordInput;
        public IWebElement GenderMaleInput;
        public IWebElement GenderFemaleInput;
        public IWebElement GenderOtherInput;
        public IWebElement DateOfInput;
        public IWebElement MaritalStatusMarriedInput;
        public IWebElement MaritalStatusUnmarriedInput;
        public IWebElement GuardianTypeFatherInput;
        public IWebElement GuardianTypeHusbandInput;
        public IWebElement GuardianNameInput;
        public IWebElement AddressInput;
        public IWebElement CitizenshipIndianInput;
        public IWebElement CitizenshipForiegnInput;
        public IWebElement CountryInput;
        public IWebElement State1Input;
        public IWebElement State2Input;
        public IWebElement AccountTypeSavingsInput;
        public IWebElement AccountTypeSalaryInput;
        public IWebElement BranchName1Input;
        public IWebElement BranchName2Input;
        public IWebElement IdentificationTypePANInput;
        public IWebElement IdentificationTypeAadharInput;
        public IWebElement IdentificationNumberInput;
        public IWebElement NomineeNameInput;
        public IWebElement NomineeAccountNumberInput;
        public IWebElement NomineeAddressInput;
        public IWebElement IntialDepositInput;

        public IWebElement RegisterButton;

        public IWebElement RegisterSuccessMessage;

        public IWebElement LoginLink;

        public RegisterPage()
        {
            NameInput = Driver.driver.FindElement(By.Id("name"));
            EmailInput = Driver.driver.FindElement(By.Id("email"));
            ContactNumberInput = Driver.driver.FindElement(By.Id("contactNumber"));
            UsernameInput = Driver.driver.FindElement(By.Id("username"));
            PasswordInput = Driver.driver.FindElement(By.Id("password"));
            GenderMaleInput = Driver.driver.FindElement(By.CssSelector("#gender > option:nth-child(2)"));
            GenderFemaleInput = Driver.driver.FindElement(By.CssSelector("#gender > option:nth-child(3)"));
            GenderOtherInput = Driver.driver.FindElement(By.CssSelector("#gender > option:nth-child(4)"));
            DateOfInput = Driver.driver.FindElement(By.Id("dateOfBirth"));
            MaritalStatusMarriedInput = Driver.driver.FindElement(By.CssSelector("#maritalStatus > option:nth-child(2)"));
            MaritalStatusUnmarriedInput = Driver.driver.FindElement(By.CssSelector("#maritalStatus > option:nth-child(3)"));
            GuardianTypeFatherInput = Driver.driver.FindElement(By.CssSelector("#guardianType > option:nth-child(2)"));
            GuardianTypeHusbandInput = Driver.driver.FindElement(By.CssSelector("#guardianType > option:nth-child(3)"));
            GuardianNameInput = Driver.driver.FindElement(By.Id("guardianName"));
            AddressInput = Driver.driver.FindElement(By.Id("address"));
            CitizenshipIndianInput = Driver.driver.FindElement(By.CssSelector("#citizenship > option:nth-child(2)"));
            CitizenshipForiegnInput = Driver.driver.FindElement(By.CssSelector("#citizenship > option:nth-child(3)"));
            CountryInput = Driver.driver.FindElement(By.CssSelector("#country > option:nth-child(2)"));
            State1Input = Driver.driver.FindElement(By.CssSelector("#state > option:nth-child(20)"));
            State2Input = Driver.driver.FindElement(By.CssSelector("#state > option:nth-child(22)"));
            AccountTypeSavingsInput = Driver.driver.FindElement(By.CssSelector("#accountType > option:nth-child(2)"));
            AccountTypeSalaryInput = Driver.driver.FindElement(By.CssSelector("#accountType > option:nth-child(3)"));
            BranchName1Input = Driver.driver.FindElement(By.CssSelector("#branchName > option:nth-child(2)"));
            BranchName1Input = Driver.driver.FindElement(By.CssSelector("#branchName > option:nth-child(3)"));
            IdentificationTypePANInput = Driver.driver.FindElement(By.CssSelector("#identificationType > option:nth-child(2)"));
            IdentificationTypeAadharInput = Driver.driver.FindElement(By.CssSelector("#identificationType > option:nth-child(3)"));
            NomineeNameInput = Driver.driver.FindElement(By.Id("referenceAccountHolderName")); ;
            NomineeAccountNumberInput = Driver.driver.FindElement(By.Id("referenceAccountHolderAccountNumber")); ;
            NomineeAddressInput = Driver.driver.FindElement(By.Id("referenceAccountHolderAddress"));
            IntialDepositInput = Driver.driver.FindElement(By.Id("initialDepositAmount"));

            LoginLink = Driver.driver.FindElement(By.CssSelector("#myNavbar > ul > li:nth-child(2) > a"));

            
        }

        public void FillIdentificationNumber()
        {
            IdentificationNumberInput = Driver.driver.FindElement(By.Id("identificationDocumentNumber"));
            IdentificationNumberInput.SendKeys("965748965874");
        }

        public void ClickRegisterButton()
        {
            RegisterButton = Driver.driver.FindElement(By.CssSelector("#registrationForm > div > div > div:nth-child(10) > button"));
            RegisterButton.Click();
        }

        public bool RegisterSuccessIsDisplayed()
        {
            RegisterSuccessMessage = Driver.driver.FindElement(By.Id("RegisterSuccess"));
            return RegisterSuccessMessage.Displayed;
        }
    }
}
