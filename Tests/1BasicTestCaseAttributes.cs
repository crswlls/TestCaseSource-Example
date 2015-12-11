using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class BasicTestCaseAttributes
    {
        /// <summary>
        /// The basic test case example shows how you can reuse test code, while varying the inputs and expected result
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The expected sum of a and b</param>
        [TestCase(1, 1, 2)]
        [TestCase(1, 2, 3)]
        [TestCase(2, 2, 4)]
        public void APlusBEqualsC(int a, int b, int c)
        {
            Assert.AreEqual(c, a + b, $"Expected {a} + {b} = {c}");
        }
    }
}