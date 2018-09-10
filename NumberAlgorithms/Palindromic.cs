using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAlgorithms
{
    public static class Palindromic
    {
        public static bool IsPalindromic(int num)
        {
            if (num == Util.ReverseNumber(num))
                return true;
            else
                return false;
        }

    }
}
