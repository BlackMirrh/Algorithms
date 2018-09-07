using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAlgorithms
{
    public static class FindMajority
    {
        public static int FindMaximumElement(int[] arr)
        {
            int max = arr[0];

            for(int i = 1; i < arr.Length -1; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

        public static int FindMajorityElement(int[] arr)
        {
            Dictionary<int, int> arrMajority = new Dictionary<int, int>();

            foreach(int i in arr)
            {
                if (arrMajority.ContainsKey(i))
                {
                    arrMajority[i]++;
                }
                else
                    arrMajority.Add(i, 1);
            }
            return arrMajority.FirstOrDefault(x => x.Value == arrMajority.Values.Max()).Key;
        }
    }
}
