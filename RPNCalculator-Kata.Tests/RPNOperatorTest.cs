using NFluent;
using NUnit.Framework;
using System;

namespace RPNCalculator_Kata.Tests
{
    class RPNOperatorTest
    {
        [TestCase(3, 5)]
        public void Sould_Sum_Two_Number(int x, int y)
        {
            // GIVEN
            Func<int, int, int> sum = RPNOperator.Sum;

            // WHEN
            int result = sum(x, y);

            // THEN
            Check.That(result).IsEqualTo(8);
        }
    }
}
