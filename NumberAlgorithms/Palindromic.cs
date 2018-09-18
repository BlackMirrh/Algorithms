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

        public static bool IsPalindrome(string word)
        {
            string newWord = word.Trim().ToLower().Replace(" ", "");

            char[] arr = newWord.ToArray();

            string reversedWord = string.Empty;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                reversedWord += arr[i];
            }
            //string reversed = string.Join("", newWord.Reverse());
            if (newWord == reversedWord)
                return true;
            else
                return false;
        }
    }
}
