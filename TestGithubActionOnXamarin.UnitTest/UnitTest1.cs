using NUnit.Framework;

namespace TestGithubActionOnXamarin.UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void NewTest()
        {
            Assert.IsTrue(false);
        }
    }
}