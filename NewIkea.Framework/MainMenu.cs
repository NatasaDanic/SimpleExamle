using OpenQA.Selenium;

namespace NewIkea.Framework
{
    public class MainMenu
    {
        private IWebDriver _driver;

        public MainMenu(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ClickOnIkeaLogo()
        {
            _driver.FindElement(By.Id("imgIKEALogoHeader")).Click();
        }
    }
}
