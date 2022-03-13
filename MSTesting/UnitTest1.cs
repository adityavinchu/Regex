using Microsoft.VisualStudio.TestTools.UnitTesting;
using validation;

namespace MSTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenCorrectPassword_ShouldReturnvalidPassword()
        {
            Pattern password = new Pattern();
            Assert.IsTrue(password.Validate("Asdf@457"));
        }
        [TestMethod]
        public void GivenWrongPassword_ShouldReturnInvalidPassword()
        {
            Pattern password = new Pattern();
            Assert.IsTrue(password.Validate("457844"));
        }
    }
}