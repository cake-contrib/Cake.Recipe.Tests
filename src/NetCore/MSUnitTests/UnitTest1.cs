using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MSTest_Sum()
        {
            Assert.AreEqual(4, MathLibrary.MathClass.Add(2, 2));
        }
    }
}
