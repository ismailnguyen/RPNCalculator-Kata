using System;
using System.Collections.Generic;

namespace RPNCalculator_Kata
{
    public class RPNParser
    {
        public Stack<int> Operands { get; private set; } = new Stack<int>();
        public Stack<Func<int, int, int>> Operators { get; private set; } = new Stack<Func<int, int, int>>();

        public void Parse(string formula)
        {
            var splittedFormula = formula.Split(' ');

            parseOperands(splittedFormula);

            parseOperators(splittedFormula);
        }

        private void parseOperands(string[] splittedFormula)
        {
            foreach (var splittedFormulaCaracter in splittedFormula)
            {
                if (int.TryParse(splittedFormulaCaracter, out int parsedCaracter))
                {
                    Operands.Push(parsedCaracter);
                }
            }
        }

        private void parseOperators(string[] splittedFormula)
        {
            foreach (var splittedFormulaCaracter in splittedFormula)
            {
                if (splittedFormulaCaracter.Equals("+"))
                {
                    Operators.Push(RPNOperator.Sum);
                }
            }
        }
    }
}