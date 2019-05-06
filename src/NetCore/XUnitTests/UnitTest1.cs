using MathLibrary;
using Xunit;

namespace XUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void XUnit_Sum()
        {
            Assert.Equal(4, MathClass.Add(2, 2));
        }
    }
}