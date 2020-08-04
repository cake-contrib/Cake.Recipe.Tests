using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumMSTests()
        {
            Assert.AreEqual(4, MathClass.Add(2, 2));
        }
    }
}