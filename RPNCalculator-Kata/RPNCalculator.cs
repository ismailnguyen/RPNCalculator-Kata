using System;

namespace RPNCalculator_Kata
{
    public class RPNCalculator
    {
        private RPNParser rpnParser = new RPNParser();

        public double Calculate(string formula)
        {
            rpnParser.Parse(formula);   

            double result = 0;

            var terms = rpnParser.Terms;

            for (int i = 0; i < terms.Count; i++)
            {
                var currentCharacter = terms[i];

                if (RPNOperator.IsOperator(currentCharacter))
                {
                    int x = int.Parse(terms[i - 2]);
                    int y = int.Parse(terms[i - 1]);

                    Func<double, double, double> operation = RPNOperator.GetOperator(currentCharacter);

                    result = operation(x, y);

                    terms[i] = result.ToString();

                    terms.RemoveAt(i - 1);
                    terms.RemoveAt(i - 2);

                    i = 0;
                }
            }

            return result;
        }
    }
}