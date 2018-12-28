using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc
{
    public static class LexicographicalOrder
    {
        public static string[] ReorderLexicographically(int logFileSize, string[] logLines)
        {
            string[] reorderedArr = new string[logFileSize];
            Dictionary<string, string> logDictionary = new Dictionary<string, string>();
            int idx = 0;
            foreach (string log in logLines)
            {
                int identifierIndex = log.IndexOf(' ');
                string identifier = log.Substring(0, identifierIndex).ToLower();
                reorderedArr[idx] = log.Substring(identifierIndex + 1).ToLower();

                logDictionary.Add(identifier, reorderedArr[idx]);
                idx++;
            }
                          
            Array.Sort(reorderedArr, new AlphanumericCompare());

            for(int i = 0; i < reorderedArr.Length; i++)
            {
                var key = logDictionary.FirstOrDefault(l => l.Value == reorderedArr[i]).Key;
                reorderedArr[i] = key + " " + reorderedArr[i];
            }
            return reorderedArr;
        }

    }
}
