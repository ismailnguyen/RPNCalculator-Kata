using System.Collections.Generic;

namespace RPNCalculator_Kata
{
    public class RPNParser
    {
        public Stack<string> Terms { get; set; } = new Stack<string>();

        public void Parse(string formula)
        {
            var splittedFormula = formula.Split(' ');

            parseTerms(splittedFormula);
        }

        private void parseTerms(string[] splittedFormula)
        {
            foreach (var splittedFormulaCaracter in splittedFormula)
            {
                Terms.Push(splittedFormulaCaracter);
            }
        }
    }
}