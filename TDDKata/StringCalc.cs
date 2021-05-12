// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Linq;

namespace TDDKata
{
    internal class StringCalc
    {
        internal int Sum(string inputValue)
        {
            if (inputValue == "")
            {
                return 0;
            }

            string[] stringValues = inputValue.Split(',');
            int totalSum = 0;
            int argumentCount = 0;
            foreach (string value in stringValues)
            {
                if (int.TryParse(value, out int result) == false)
                {
                    throw new ArgumentException();
                }
                else
                {
                    totalSum += result;
                }

                ++argumentCount;
                if (argumentCount > 2)
                {
                    throw new IndexOutOfRangeException();
                }
            }

            return totalSum;
        }
    }
}