using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAlgorithms
{
    public static class Util
    {
        public static int CountDigit(int n)
        {
            if (n == 0)
                return 0;
            return 1 + CountDigit(n / 10);
        }

        public static int ReverseNumber(int n)
        {
            int reverse = 0, remainder = 0;

            while(n > 0)
            {
                remainder = n % 10;
                reverse = reverse * 10 + remainder;
                n /= 10;
            }

            return reverse;
        }
    }
}
