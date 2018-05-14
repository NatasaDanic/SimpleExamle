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
    }
}
