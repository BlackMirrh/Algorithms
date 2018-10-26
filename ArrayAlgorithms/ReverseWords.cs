using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAlgorithms
{
    public class ReverseWords
    {
        public string[] ReverseWordsWithInArray(string str)
        {
            string[] words = str.Split(' ');
            int n = words.Length - 1;
            int cnt = n / 2;

            for(int i = 0; i <= cnt; i++)
            {
                string tmp = words[i];
                words[i] = words[n];
                words[n] = tmp;
                n--;
            }
            return words;
        }

    }
}
