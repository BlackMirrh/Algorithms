using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    public class LIS
    {
        public static int GetLIS(int[] arr)
        {
            int maxCnt = 0;
            
            for(int i = 0; i < arr.Length - 1; i++)
            {
                int lisCnt = 1;
                int idx = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[idx] < arr[j])
                    {
                        idx = j;
                        lisCnt++;
                    }
                }

                if (lisCnt > maxCnt)
                    maxCnt = lisCnt;
            }

            return maxCnt;
        }
    }
}
