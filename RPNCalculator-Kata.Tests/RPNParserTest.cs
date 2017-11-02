using NFluent;
using NUnit.Framework;

namespace RPNCalculator_Kata.Tests
{
    class RPNParserTest
    {
        [Test]
        public void Sould_Parser_Operands_Contains_Operands_From_Formula()
        {
            // GIVEN
            string formula = "5 3 +";
            RPNParser rpnParser = new RPNParser();

            // WHEN
            rpnParser.Parse(formula);

            // THEN
            Check.That(rpnParser.Operands).Contains(5, 3);
        }
    }
}
