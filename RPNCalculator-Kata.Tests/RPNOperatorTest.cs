using NFluent;
using NUnit.Framework;
using System;

namespace RPNCalculator_Kata.Tests
{
    class RPNOperatorTest
    {
        [TestCase(3, 5, 8)]
        [TestCase(4, 5, 9)]
        public void Sould_Sum_Two_Number(double x, double y, double expectedResult)
        {
            // GIVEN
            Func<double, double, double> sum = RPNOperator.Sum;

            // WHEN
            double result = sum(x, y);

            // THEN
            Check.That(result).IsEqualTo(expectedResult);
        }

        [TestCase(3, 5, -2)]
        [TestCase(44, 5, 39)]
        public void Sould_Substract_Two_Number(double x, double y, double expectedResult)
        {
            // GIVEN
            Func<double, double, double> substract = RPNOperator.Substract;

            // WHEN
            double result = substract(x, y);

            // THEN
            Check.That(result).IsEqualTo(expectedResult);
        }

        [TestCase(30, 5, 6)]
        [TestCase(15, 3, 5)]
        public void Sould_Divide_Two_Number(double x, double y, double expectedResult)
        {
            // GIVEN
            Func<double, double, double> divide = RPNOperator.Divide;

            // WHEN
            double result = divide(x, y);

            // THEN
            Check.That(result).IsEqualTo(expectedResult);
        }

        [TestCase(3, 5, 15)]
        [TestCase(15, 3, 45)]
        public void Sould_Multiply_Two_Number(double x, double y, double expectedResult)
        {
            // GIVEN
            Func<double, double, double> multiply = RPNOperator.Multiply;

            // WHEN
            double result = multiply(x, y);

            // THEN
            Check.That(result).IsEqualTo(expectedResult);
        }

        [TestCase("x")]
        [TestCase("-")]
        [TestCase("+")]
        [TestCase("/")]
        public void Sould_Check_String_Match_With_Operator(string character)
        {
            // WHEN
            bool isOperator = RPNOperator.IsOperator(character);

            // THEN
            Check.That(isOperator).IsTrue();
        }

        [Test]
        public void Sould_Return_Method_Corresponding_To_Operator()
        {
            // GIVEN
            var character = "x";

            // WHEN
            Func<double, double, double> op = RPNOperator.GetOperator(character);

            // THEN
            Func<double, double, double> expectedOperator = RPNOperator.Multiply;
            Check.That(op).IsEqualTo(expectedOperator);
        }
    }
}
