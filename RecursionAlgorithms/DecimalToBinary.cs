using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionAlgorithms
{
    public static class DecimalToBinary
    {
        public static int BinaryConversion(int num)
        {
            if (num == 0)
                return 0;
            else
                return (num % 2 + 10 * BinaryConversion(num / 2));
        }
    }
}
