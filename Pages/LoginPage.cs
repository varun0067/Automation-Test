

using OpenQA.Selenium;

namespace BMS_AutomationTest.Pages
{
    public class LoginPage
    {
        public IWebElement UsernameInput;
        public IWebElement PasswordInput;
        public IWebElement LoginButton;
        public IWebElement InvalidAlert;
        public IWebElement RegisterLink;
        public IWebElement RegisterLinkHeader;

        public LoginPage()
        {
            UsernameInput = Driver.driver.FindElement(By.Id("username"));
            PasswordInput = Driver.driver.FindElement(By.Id("password"));
            
        }


        public void ClickLogin()
        {
            LoginButton = Driver.driver.FindElement(By.CssSelector("body > main > form > div > div > button"));
            LoginButton.Click();
        }

        public string GetInvalidResponse()
        {
            InvalidAlert=Driver.driver.FindElement(By.XPath("/html/body/app-root/app-home/body/main/form/div/div/div[3]/div/div"));
            return InvalidAlert.Text;
        }
        public IWebElement GetRegisterLink()
        {
            return RegisterLink = Driver.driver.FindElement(By.CssSelector("body > main > h4 > button"));
        }
        public IWebElement GetRegisterLinkFromHeader()
        {
            return RegisterLinkHeader = Driver.driver.FindElement(By.CssSelector("#myNavbar > ul > li:nth-child(1) > a"));
        }
    }
}
