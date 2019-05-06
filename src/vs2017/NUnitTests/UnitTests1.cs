using NUnit.Framework;

namespace NUnitTests
{
    [TestFixture]
    public class UnitTests1
    {
        [Test]
        public void SumNUnit()
        {
            Assert.That(MathClass.Add(2, 2), Is.EqualTo(4));
        }
    }
}