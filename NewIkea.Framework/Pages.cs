using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace NewIkea.Framework
{
    public static class Pages
    {
        private static IWebDriver _driver;

        public static HomePage HomePage => new HomePage(_driver);
        public static HeaderLinks HeaderLinks => new HeaderLinks(_driver);
        public static MainMenu MainMenu => new MainMenu(_driver);

        public static void Close()
        {
            _driver.Close();
        }

        public static void Initialize()
        {
            _driver = new FirefoxDriver();
        }

        public static string CurrentPageTitle => _driver.Title;        
    }
}
