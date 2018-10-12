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

        // num = 5
        // arr = [2,4,6,8,10]
        // Output = 2

        // arr = [2,3,4,5,6]
        // Output = 1
        public static int generalizedGCD(int num, int[] arr)
        {
            int result = 1;

            for(int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (i != j)
                    {
                        int gcd = GCD(arr[i], arr[j]);
                        if (gcd > result)
                            result = gcd;
                    }
                }
            }
            return result;
        }

        public static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }
    }
}
