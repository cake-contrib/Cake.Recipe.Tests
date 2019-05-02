using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTests
{
    [TestFixture]
    public class UnitTests1
    {
        [Test]
        public void SumNUnitV2()
        {
            Assert.That(MathClass.Add(2, 2), Is.EqualTo(4));
        }
    }
}
