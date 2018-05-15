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

        public void ClickOnInspirationLink()
        {
            _driver.FindElement(By.LinkText("INSPIRATION")).Click();
        }

        public void ClickOnThisIsIkeaLink()
        {
            _driver.FindElement(By.LinkText("THIS IS IKEA")).Click();
        }

        public void ClickOnNewLowerPrices()
        {
            _driver.FindElement(By.LinkText("NEW LOWER PRICES")).Click();
        }

        public void ClickOnProductLink()
        {
            _driver.FindElement(By.LinkText("PRODUCTS")).Click();
        }

        public bool IsProductDivVisible()
        {
            return _driver.FindElement(By.Id("menu-drawer-nh")).Displayed;
        }

        public void ClickOnRoomsLink()
        {
            _driver.FindElement(By.LinkText("ROOMS")).Click();
        }

        public bool IsRoomsDivVisible()
        {
            return _driver.FindElement(By.Id("rooms-drawer")).Displayed;
        }
        
        public MainMenu ClickOnSearchTextBox()
        {
            _driver.FindElement(By.Id("search")).Click();
            return this;
        }

        public MainMenu PopulateSearchBox()
        {
            _driver.FindElement(By.Id("search")).SendKeys("brown");
            return this;
        }

        public MainMenu ClickSearchButton()
        {
            _driver.FindElement(By.XPath("//input[@alt='Search']")).Click();
            return this;
        }

    }
}
