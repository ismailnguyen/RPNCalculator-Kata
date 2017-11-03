using System;
using System.Collections.Generic;

namespace RPNCalculator_Kata
{
    public class RPNParser
    {
        public Stack<int> Operands { get; private set; } = new Stack<int>();
        public Stack<Func<double, double, double>> Operators { get; private set; } = new Stack<Func<double, double, double>>();
        public Stack<string> Terms { get; set; } = new Stack<string>();

        public void Parse(string formula)
        {
            var splittedFormula = formula.Split(' ');

            parseOperands(splittedFormula);

            parseOperators(splittedFormula);

            parseTerms(splittedFormula);
        }

        private void parseTerms(string[] splittedFormula)
        {
            foreach (var splittedFormulaCaracter in splittedFormula)
            {
                Terms.Push(splittedFormulaCaracter);
            }
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

                if (splittedFormulaCaracter.Equals("-"))
                {
                    Operators.Push(RPNOperator.Substract);
                }

                if (splittedFormulaCaracter.Equals("x"))
                {
                    Operators.Push(RPNOperator.Multiply);
                }

                if (splittedFormulaCaracter.Equals("/"))
                {
                    Operators.Push(RPNOperator.Divide);
                }
            }
        }
    }
}