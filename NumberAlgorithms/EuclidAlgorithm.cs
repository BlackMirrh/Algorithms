using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAlgorithms
{
    public static class EuclidAlgorithm
    {
        public static int GCDRecursive (int a, int b)
        {
            if (a == 0)
                return b;
            if (b == 0)
                return a;

            if (a > b)
                return GCDRecursive(a % b, b);
            else
                return GCDRecursive(a, b % a);
        }

        public static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            if (a == 0)
                return b;
            else
                return a;
        }

        public static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }
    }
}
