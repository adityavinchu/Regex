using Microsoft.VisualStudio.TestTools.UnitTesting;
using validation;
namespace MSTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Pattern password = new Pattern();
            Assert.IsTrue(password.Validate("Asjsl@457"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Pattern password = new Pattern();
            Assert.IsTrue(password.Validate("457844"));
        }
    }
}