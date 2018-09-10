using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionAlgorithms
{
    public static class SumOfDigits
    {
        public static int GetSumOfDigits(int num)
        {
            int remainder = (num % 10);
            num /= 10;
            if (num <= 0)
                return remainder;

            return remainder + GetSumOfDigits(num);
        }
    }
}
