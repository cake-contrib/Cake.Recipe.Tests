using Xunit;

namespace XUnitTests
{
    public class UnitTests1
    {
        [Fact]
        public void SumxUnit()
        {
            Assert.Equal(4, MathClass.Add(2, 2));
        }
    }
}