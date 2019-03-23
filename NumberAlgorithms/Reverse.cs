using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAlgorithms
{
    public class Reverse
    {
        public int ReverseNumber(int num)
        {
            int rev = 0;

            while(num != 0)
            {
                int pop = num % 10;
                num /= 10;
                if (rev > int.MaxValue / 10 || (rev == int.MaxValue / 10 && pop > 7))
                    return 0;
                if (rev < int.MinValue / 10 || (rev == int.MinValue / 10 && pop < -8))
                    return 0;
                rev = rev * 10 + pop;
            }                        

            return rev;
        }
    }
}
