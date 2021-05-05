using NUnit.Framework;
using Xamarin.Forms;

namespace TestGithubActionOnXamarin.UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Application.Current = new App();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void NewTest()
        {
            Assert.IsTrue(true);
        }
    }
}