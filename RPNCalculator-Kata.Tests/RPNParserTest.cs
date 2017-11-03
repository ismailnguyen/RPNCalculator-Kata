using NFluent;
using NUnit.Framework;
using System;

namespace RPNCalculator_Kata.Tests
{
    class RPNParserTest
    {
        [Test]
        public void Sould_Parser_Contains_Operands_From_Formula()
        {
            // GIVEN
            string formula = "5 3 + 4 6";
            RPNParser rpnParser = new RPNParser();

            // WHEN
            rpnParser.Parse(formula);

            // THEN
            Check.That(rpnParser.Operands).Contains(5, 3, 4, 6);
        }

        [Test]
        public void Sould_Parser_Contains_Operators_From_Formula()
        {
            // GIVEN
            string formula = "5 - * / 3 +";
            RPNParser rpnParser = new RPNParser();

            // WHEN
            rpnParser.Parse(formula);

            // THEN
            Func<double, double, double> expectedOperatorSubstract = RPNOperator.Substract;
            Func<double, double, double> expectedOperatorMultiply = RPNOperator.Multiply;
            Func<double, double, double> expectedOperatorDivide = RPNOperator.Divide;
            Func<double, double, double> expectedOperatorSum = RPNOperator.Sum;

            //Check.That(rpnParser.Operators).Contains(expectedOperatorSubstract, expectedOperatorMultiply, expectedOperatorDivide, expectedOperatorSum);
        }

        [Test]
        public void Sould_Parser_Contains_Terms_From_Formula()
        {
            // GIVEN
            string formula = "5 3 +";
            RPNParser rpnParser = new RPNParser();

            // WHEN
            rpnParser.Parse(formula);

            // THEN
            Check.That(rpnParser.Terms).Contains("5", "3", "+");
        }
    }
}
