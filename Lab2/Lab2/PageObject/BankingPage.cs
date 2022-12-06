using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PageObject
{
    public class BankingPage : BasePage
    {
        private static WebDriverWait wait;
        public BankingPage(IWebDriver webDriver) : base(webDriver)
        {
            
        }
        private IWebElement btnСustomerLogin => driver.FindElement(By.XPath("//button[@ng-click=\"customer()\"]"));
        public void ClickСustomerLogin() => btnСustomerLogin.Click();
    }
}
