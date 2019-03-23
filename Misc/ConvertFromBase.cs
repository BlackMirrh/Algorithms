using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc
{
    public class ConvertFromBase
    {
        public bool compareBinToHex (string binary, string hex)
        {
            int n1 = convertByBase(binary, 2);
            int n2 = convertByBase(hex, 16);
            if (n1 < 0 || n2 < 0)
                return false;
            return n1 == n2;
        }

        int convertByBase(string number, int baseCode)
        {
            if (baseCode < 2 || (baseCode > 10 && baseCode != 16)) return -1;

            int value = 0;
            for (int i = number.Length -1; i >= 0; i--)
            {
                int digit = digitToValue(number.ElementAt(i));
                if (digit < 0 || digit >= baseCode)
                    return -1;
                int exp = number.Length - 1 - i;
                value += digit * (int)Math.Pow(baseCode, exp);
            }
            return value;
        }

        int digitToValue(char c)
        {
            int digit = -1;
            if (int.TryParse(c.ToString(), out digit))
            {
                if (digit >= 0 && digit <= 9)
                    return digit;
            }
            else
            {
                digit = (int)c - 55;
                if (digit >= 10 && digit <= 15)
                    return digit;
            }
            return digit;
        }
    }
}
