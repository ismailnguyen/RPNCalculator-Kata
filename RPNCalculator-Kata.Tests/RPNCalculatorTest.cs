using NFluent;
using NUnit.Framework;

namespace RPNCalculator_Kata.Tests
{
    class RPNCalculatorTest
    {
        [TestCase("5 3 +", 8)]
        [TestCase("6 2 /", 3)]
        [TestCase("5 2 - 7 +", 10)]
        [TestCase("7 5 2 - +", 10)]
        [TestCase("3 5 8 x 7 + x", 141)]
        [TestCase("3 4 2 1 + x + 2 /", 7.5)]
        [TestCase("1 2 + 4 x 5 + 3 -", 14)]
        public void Should_Calculate_RPN_Formulas(string formula, double expectedResult)
        {
            // GIVEN
            RPNCalculator rpnCalculator = new RPNCalculator();

            // WHEN
            double result = rpnCalculator.Calculate(formula);

            // THEN
            Check.That(result).IsEqualTo(expectedResult);
        }
    }
}
