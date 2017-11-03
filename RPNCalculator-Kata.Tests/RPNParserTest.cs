using NFluent;
using NUnit.Framework;

namespace RPNCalculator_Kata.Tests
{
    class RPNParserTest
    {
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
