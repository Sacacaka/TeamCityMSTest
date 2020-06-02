using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TeamCityUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = TeamCity.Program.Sum(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int result = TeamCity.Program.Sum(0, 3);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int result = TeamCity.Program.Sum(-2, 3);
            Assert.AreEqual(1, result);
        }
    }
}
