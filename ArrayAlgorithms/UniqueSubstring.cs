using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAlgorithms
{
    public class UniqueSubstring
    {
        public long NumberOfDistinctSubstring(string str)
        {
            long cnt = 0;
            //string final = "";

            for(int i =0; i < str.Length; i++)
            {
                string s = string.Empty;    // str.Substring(i, str.Length - i);
                
                for(int j = i; j < str.Length; j++)
                {
                    s += str[j];
                    //final += str + ",";
                    cnt += 1;
                    Console.WriteLine(s);
                }
            }
            return cnt;
        }
    }
}
