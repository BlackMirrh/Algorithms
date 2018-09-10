using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAlgorithms
{
    public static class NarcissisticNumber
    {
        

        public static bool IsNarcissisticNumber(int n)
        {
            int exponent = Util.CountDigit(n);
            int dup = n;
            int sum = 0;

            while(dup > 0)
            {
                sum += (int)Math.Pow(dup % 10, exponent);
                dup /= 10;
            }

            return (n == sum);
        }

        public static bool IsArmstrongNumber(int num)
        {
            if (num <= 0)
                throw new Exception("Invalid argument");

            string val = num.ToString();
            int exponent = val.Length;
            double sum = 0;

            foreach(char c in val)
            {
                sum += Math.Pow(Char.GetNumericValue(c), exponent);
            }

            if (num == (int)sum)
                return true;
            else
                return false;
        }
    }
}
