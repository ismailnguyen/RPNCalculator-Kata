using System;
using System.Collections.Generic;
using System.Linq;

namespace RPNCalculator_Kata
{
    public class RPNCalculator
    {
        private RPNParser rpnParser = new RPNParser();

        public double Calculate(string formula)
        {
            rpnParser.Parse(formula);

            double result = 0;

            var tempFormula = new Queue<string>();

            for(int i=0; i<formula.Length; i++)
            {
                if (formula[i].Equals(' '))
                {
                    continue;
                }

                tempFormula.Enqueue(formula[i].ToString());
            }

            int count = tempFormula.Count;
            for (int j = 0; j < count; j++)
            {
                var tab = tempFormula.ToArray();
                var caracter = tab[j];

                if (isOperator(caracter))
                {
                    int x = int.Parse(tab[j-2]);
                    int y = int.Parse(tab[j-1]);

                    Func<double, double, double> op = null;

                    if (caracter.Equals("+"))
                    {
                        op = RPNOperator.Sum;
                    }

                    if (caracter.Equals("-"))
                    {
                        op = RPNOperator.Substract;
                    }

                    if (caracter.Equals("x"))
                    {
                        op = RPNOperator.Multiply;
                    }

                    if (caracter.Equals("/"))
                    {
                        op = RPNOperator.Divide;
                    }

                    result = op(x, y);

                    var actualTab = tempFormula.ToList();
                    actualTab[j] = result.ToString();
                    actualTab.RemoveAt(j-1);
                    actualTab.RemoveAt(j-2);

                    tempFormula = new Queue<string>(actualTab);
                    count = actualTab.Count;
                    j = 0;
                }
            }

            return result;
        }

        private bool isOperator(string caracter)
        {
            return caracter.Equals("+")
                || caracter.Equals("-")
                 || caracter.Equals("x")
                  || caracter.Equals("/");
        }
    }
}