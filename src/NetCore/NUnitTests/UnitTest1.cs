using MathLibrary;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void NUnit_Sum()
        {
            Assert.That(MathClass.Multiply(4, 2), Is.EqualTo(8));
        }
    }
}