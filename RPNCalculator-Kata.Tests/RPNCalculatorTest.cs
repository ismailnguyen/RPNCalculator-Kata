using NFluent;
using NUnit.Framework;

namespace RPNCalculator_Kata.Tests
{
    class RPNCalculatorTest
    {
        [TestCase("5 3 +", 8)]
        [TestCase("6 2 /", 3)]
        public void Sould_Add_Two_Number(string formula, int expectedResult)
        {
            // GIVEN
            RPNCalculator rpnCalculator = new RPNCalculator();

            // WHEN
            double result = rpnCalculator.Calculate(formula);

            // THEN
            Check.That(result).IsEqualTo(8);
        }
    }
}
