using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calc;

        [SetUp]
        public void Init()
        {
            _calc = new Calculator();
        }

        [TearDown]
        public void Cleanup()
        {
            _calc = null;
        }

        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(5, 5, 10)]
        [TestCase(-1, 1, 0)]
        public void Add_WhenCalled_ReturnsExpectedResult(int a, int b, int expected)
        {
            var result = _calc.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Ignore("This test is under development")]
        public void Add_ToBeIgnored()
        {
            Assert.Fail("This should be ignored.");
        }
    }
}