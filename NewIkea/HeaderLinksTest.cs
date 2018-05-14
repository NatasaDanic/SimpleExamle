using NewIkea.Framework;
using NUnit.Framework;

namespace NewIkea.Tests
{
    public class HeaderLinksTests : TestFixture
    {
        [Test]
        public void IkeaFamillyLink_ShouldRedirectToIkeaFamillyPage()
        {
            Pages.HeaderLinks.ClickOnIkeaFamillyLink();

            Assert.IsTrue(Pages.CurrentPageTitle == "IKEA FAMILY | IKEA Australia - IKEA");
        }

        [Test]
        public void IkeaBusinesLink_ShouldRedirectToBusinesPage()
        {
            Pages.HeaderLinks.ClickOnIkeaBusinesLink();

            Assert.IsTrue(Pages.CurrentPageTitle == "Business furniture for hospitality, retail and offices – IKEA");
        }

        [Test]
        public void YourIkeaLocationLink_ShouldRedirectToYourIkeaLocationsPage()
        {
            Pages.HeaderLinks.ClickOnYourIkeaLocationLink();

            Assert.IsTrue(Pages.CurrentPageTitle == "Find your local IKEA store - IKEA");
        }

        [Test]
        public void CustomerServicesLink_ShouldRedirectToCustomerServicesPage()
        {
            Pages.HeaderLinks.ClickOnCustomerServicesLink();

            Assert.IsTrue(Pages.CurrentPageTitle == "Customer Service - IKEA");
        }

        [Test]
        public void MyAccountLink_ShouldRedirectToMyAccountPage()
        {
            Pages.HeaderLinks.ClickOnMyAccountLink();

            Assert.IsTrue(Pages.CurrentPageTitle == "Login - IKEA");
        }
    }
}
