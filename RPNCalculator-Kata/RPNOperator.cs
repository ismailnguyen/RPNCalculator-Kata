using System;

namespace RPNCalculator_Kata
{
    public class RPNOperator
    {
        public static double Sum(double x, double y)
        {
            return x + y;
        }

        public static double Substract(double x, double y)
        {
            return x - y;
        }

        public static double Divide(double x, double y)
        {
            return x / y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static bool IsOperator(string character)
        {
            return character.Equals("+")
                || character.Equals("-")
                 || character.Equals("x")
                  || character.Equals("/");
        }

        public static Func<double, double, double> GetOperator(string character)
        {
            switch (character)
            {
                case "+": return Sum;
                case "-": return Substract;
                case "x": return Multiply;
                case "/": return Divide;

                default: throw new ArgumentException("Character doesn't match with an operator. (Use + - x /)");
            }
        }
    }
}
