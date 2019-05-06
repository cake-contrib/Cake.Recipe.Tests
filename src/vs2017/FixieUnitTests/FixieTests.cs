using Shouldly;

namespace FixieUnitTests
{
    public class FixieTests
    {
        public void ShouldSum()
        {
            MathClass.Add(2, 2).ShouldBe(4);
        }
    }
}