using NewIkea.Framework;
using NUnit.Framework;

namespace NewIkea.Tests
{
    public class HomePageTests : TestFixture
    {
        [Test]
        public void IsHomePageTitleCorrect()
        {
            Assert.IsTrue(Pages.CurrentPageTitle == "IKEA | Affordable Swedish Home Furniture - IKEA");
        }
    }
}
