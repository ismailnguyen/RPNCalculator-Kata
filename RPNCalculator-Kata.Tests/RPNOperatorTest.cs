using NFluent;
using NUnit.Framework;
using System;

namespace RPNCalculator_Kata.Tests
{
    class RPNOperatorTest
    {
        [TestCase(3, 5, 8)]
        [TestCase(4, 5, 9)]
        public void Sould_Sum_Two_Number(int x, int y, int expectedResult)
        {
            // GIVEN
            Func<int, int, int> sum = RPNOperator.Sum;

            // WHEN
            int result = sum(x, y);

            // THEN
            Check.That(result).IsEqualTo(expectedResult);
        }

        [TestCase(3, 5, -2)]
        [TestCase(44, 5, 39)]

        public void Sould_Substract_Two_Number(int x, int y, int expectedResult)
        {
            // GIVEN
            Func<int, int, int> substract = RPNOperator.Substract;

            // WHEN
            int result = substract(x, y);

            // THEN
            Check.That(result).IsEqualTo(expectedResult);
        }
    }
}
