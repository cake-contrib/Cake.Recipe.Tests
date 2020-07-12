using MathLibrary;
using Xunit;

namespace XUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void XUnit_Sum()
        {
            Assert.Equal(0, MathClass.Subtract(2, 2));
        }
    }
}