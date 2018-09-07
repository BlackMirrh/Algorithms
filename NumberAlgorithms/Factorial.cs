using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAlgorithms
{
    public static class Factorial
    {
        public static int Fac(int n)
        {
            int facResult = 1;
            for(int i = n; i >= 1; i--)
            {
                facResult = facResult * i;
            }
            return facResult;
        }

        public static int FacRecursion(int n)
        {
            if (n == 1)         
                return 1;
            else
                return n * FacRecursion(n - 1);
        }

    }
}
