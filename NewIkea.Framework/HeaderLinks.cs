using OpenQA.Selenium;

namespace NewIkea.Framework
{
    public class HeaderLinks
    {
        private IWebDriver _driver;

        public HeaderLinks(IWebDriver driver)
        {
            _driver = driver;
        }
        
        public void ClickOnIkeaFamillyLink()
        {
            _driver.FindElement(By.Id("link_header_home")).Click();
        }

        public void ClickOnIkeaBusinesLink()
        {
            _driver.FindElement(By.Id("link_header_www.ikea")).Click();
        }

        public void ClickOnYourIkeaLocationLink()
        {
            _driver.FindElement(By.Id("link_header_ikny_splash")).Click();
        }

        public void ClickOnCustomerServicesLink()
        {
            _driver.FindElement(By.Id("link_header_index")).Click();
        }

        public void ClickOnMyAccountLink()
        {
            _driver.FindElement(By.Id("link_header_update_user")).Click();
        }
    }
}
