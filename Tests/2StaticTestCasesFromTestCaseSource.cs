using System.Collections;
using NUnit.Framework;


namespace Tests
{
    [TestFixture]
    public class StaticTestCasesFromTestCaseSource
    {
        /// <summary>
        /// You can use the TestCaseSource to specify a method that provides the input values
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The expected sum of a and b</param>
        [TestCaseSource("GetTestCaseInputs")]
        public void APlusBEqualsC(int a, int b, int c)
        {
            Assert.AreEqual(c, a + b, $"Expected {a} + {b} = {c}");
        }

        public static IEnumerable GetTestCaseInputs()
        {
            return new []
            {
                new [] { 1, 1, 2 },
                new [] { 1, 2, 3 },
                new [] { 2, 2, 4 },
            };
        }
    }
}

