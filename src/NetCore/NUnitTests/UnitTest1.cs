using MathLibrary;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void NUnit_Sum()
        {
            Assert.That(MathClass.Add(2, 2), Is.EqualTo(4));
        }
    }
}