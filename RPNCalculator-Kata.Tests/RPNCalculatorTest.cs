using NFluent;
using NUnit.Framework;

namespace RPNCalculator_Kata.Tests
{
    class RPNCalculatorTest
    {
        [Test(Description = "5 3 + => 5+3 => 8")]
        public void Sould_Add_Two_Number()
        {
            // GIVEN
            string formula = "5 3 +";
            RPNCalculator rpnCalculator = new RPNCalculator();

            // WHEN
            double result = rpnCalculator.Calculate(formula);

            // THEN
            Check.That(result).IsEqualTo(8);
        }
    }
}
