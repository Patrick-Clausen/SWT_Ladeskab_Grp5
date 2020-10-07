using System;
using NUnit.Framework;

namespace Ladeskab.UnitTests
{
    [TestFixture]
    public class BasicTestFixture
    {
        [Test]
        public void AlwaysPassTest()
        {
            Assert.That(1,Is.EqualTo(1));
        }
    }
}
