using NewIkea.Framework;
using NUnit.Framework;

namespace NewIkea.Tests
{
    class MainMenyTests : TestFixture
    {
        [Test]
        public void IkeaLogo_ShouldLoadHomePage()
        {
            Pages.MainMenu.ClickOnIkeaLogo();

            Assert.IsTrue(Pages.CurrentPageTitle == "IKEA | Affordable Swedish Home Furniture - IKEA");
        }

        [Test]
        public void InspirationLink_ShouldRedirectToInspirationPage()
        {
            Pages.MainMenu.ClickOnInspirationLink();

            Assert.IsTrue(Pages.CurrentPageTitle == "IKEA + you");
        }

        [Test]
        public void ThisIsIkeaLink_ShouldRedirectToThisIsIkeaPage()
        {
            Pages.MainMenu.ClickOnThisIsIkeaLink();

            Assert.IsTrue(Pages.CurrentPageTitle == "This is IKEA - IKEA");
        }

        [Test]
        public void NewLowerPricesLink_ShoulRedirectToNewLowerPricesPage()
        {
            Pages.MainMenu.ClickOnNewLowerPrices();

            Assert.IsTrue(Pages.CurrentPageTitle == "New Lower Prices | IKEA Australia - IKEA");
        }

        [Test]
        public void WhenClickedOnProductLink_ShouldShowProductsDropDownMenu()
        {
            Pages.MainMenu.ClickOnProductLink();

            Assert.AreEqual(true, Pages.MainMenu.IsProductDivVisible());
        }

        [Test]
        public void WhenClickOnRoomsLink_ShouldShowRoomsDropDownMenu()
        {
            Pages.MainMenu.ClickOnRoomsLink();

            Assert.AreEqual(true, Pages.MainMenu.IsRoomsDivVisible());
        }

        [Test]
        public void SearchButton_ShouldRedirectToSearchPage()
        {
            Pages.MainMenu.ClickOnSearchButton();

            Assert.IsTrue(Pages.CurrentPageTitle == "Search result - IKEA");
        }
    }
}
