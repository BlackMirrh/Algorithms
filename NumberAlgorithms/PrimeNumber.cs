using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAlgorithms
{
    public static class PrimeNumber
    {
        public static bool IsPrimeNumber(int num)
        {
            for(int i = 2; i <= num /2; i++)
            {
                if ((num % i) == 0)
                    return false;
            }
            return true;
        }

    }
}
