﻿using System;

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

        public static bool IsOperator(string caracter)
        {
            return caracter.Equals("+")
                || caracter.Equals("-")
                 || caracter.Equals("x")
                  || caracter.Equals("/");
        }

        public static Func<double, double, double> GetOperator(string caracter)
        {
            if (caracter.Equals("+"))
            {
                return Sum;
            }

            if (caracter.Equals("-"))
            {
                return Substract;
            }

            if (caracter.Equals("x"))
            {
                return Multiply;
            }

            if (caracter.Equals("/"))
            {
                return Divide;
            }

            throw new ArgumentException("Caracter doesn't match with an operator. (Use + - x /)");
        }
    }
}
