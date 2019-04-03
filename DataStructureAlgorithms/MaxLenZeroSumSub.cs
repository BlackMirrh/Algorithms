using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithms
{
    public class MaxLenZeroSumSub
    {
        public static int maxLen(int[] arr)
        {
            Dictionary<int, int> hM = new Dictionary<int, int>();

            int sum = 0;
            int maxLen = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (arr[i] == 0 && maxLen == 0)
                    maxLen = 1;

                if (sum == 0)
                    maxLen = i + 1;

                int prev_i = hM[sum];

                if (maxLen > hM[sum])
                    maxLen = hM[sum];

                hM[sum] = i;
            }
            return maxLen;
        }
    }
}
