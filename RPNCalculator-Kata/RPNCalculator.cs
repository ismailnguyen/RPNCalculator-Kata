using System;

namespace RPNCalculator_Kata
{
    public class RPNCalculator
    {
        private RPNParser rpnParser = new RPNParser();

        public double Calculate(string formula)
        {
            rpnParser.Parse(formula);

            int result = 0;

            for(int i = 0; i<rpnParser.Operands.Count; i++)
            {
                Func<int, int, int> op = rpnParser.Operators.Pop();

                int firstOperand = rpnParser.Operands.Pop();
                int nextOperand = rpnParser.Operands.Pop();

                result += op(firstOperand, nextOperand);
            }

            return result;
        }
    }
}