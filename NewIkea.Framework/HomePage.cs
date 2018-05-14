using OpenQA.Selenium;

namespace NewIkea.Framework
{
    public class HomePage
    {
        private IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void GoToHomePage()
        {
            _driver.Url = "https://www.ikea.com/au/en/";
        }
    }
}
