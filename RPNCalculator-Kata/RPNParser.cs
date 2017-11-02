using System.Collections.Generic;

namespace RPNCalculator_Kata
{
    public class RPNParser
    {
        public IList<int> Operands { get; private set; } = new List<int>();

        public void Parse(string formula)
        {
            var splittedFormula = formula.Split(' ');

            foreach(var splittedFormulaCaracter in splittedFormula)
            {
                if (int.TryParse(splittedFormulaCaracter, out int parsedCaracter))
                {
                    Operands.Add(parsedCaracter);
                }
            }
        }
    }
}