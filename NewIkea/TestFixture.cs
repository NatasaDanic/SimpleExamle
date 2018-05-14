using NewIkea.Framework;
using NUnit.Framework;

namespace NewIkea.Tests
{
    public class TestFixture
    {
        [SetUp]
        public void SetUp()
        {
            Pages.Initialize();
            Pages.HomePage.GoToHomePage();
        }

        [TearDown]
        public void Close()
        {
            Pages.Close();
        }
    }
}
