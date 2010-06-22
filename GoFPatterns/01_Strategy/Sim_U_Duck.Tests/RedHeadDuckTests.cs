using NUnit.Framework;
using Sim_U_Duck.Ducks;

namespace Sim_U_Duck.Tests
{
    [TestFixture]
    public class RedHeadDuckTests
    {
        private Duck duck;
        private TestWriter testWriter;

        [SetUp]
        public void SetUp()
        {
            testWriter = new TestWriter();
            duck = new RedHeadDuck(testWriter);
        }

        [Test]
        public void test_simple_quack()
        {
            duck.Quack();
            Assert.That(testWriter.LastMessage, Is.EqualTo("Quack!"));
        }
    }
}