using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc
{
    public static class MostFrequent
    {
        public static string[] FindMostFrequent(string[] arr, string[] excludeArr)
        {
            // Find the max frequency using linear traversal
            Dictionary<string, int> res = new Dictionary<string, int>();
            int maxCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (excludeArr.Contains(arr[i]) || arr[i] == string.Empty)
                    continue;

                if (res.Keys.Contains(arr[i]))
                {
                    res[arr[i]]++;
                    maxCount = res[arr[i]];
                }
                else
                    res.Add(arr[i], 1);
            }

            return res.Where(x => x.Value == maxCount).Select(k => k.Key).ToArray();
        }
    }
}
