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
            Func<int, int, int> expectedOperatorSum = RPNOperator.Sum;
            Func<int, int, int> expectedOperatorSubstract = RPNOperator.Substract;
            Func<int, int, int> expectedOperatorMultiply = RPNOperator.Multiply;
            Func<int, int, int> expectedOperatorDivide = RPNOperator.Divide;

            Check.That(rpnParser.Operators).Contains(expectedOperatorSum, expectedOperatorSubstract, expectedOperatorMultiply, expectedOperatorDivide);
        }
    }
}
