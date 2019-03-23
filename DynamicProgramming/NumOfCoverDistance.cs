using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    public class NumOfCoverDistance
    {
        public static int Distance (int n)
        {
            int[] count = new int[n + 1];

            count[0] = 1;
            count[1] = 1;
            count[2] = 2;

            for(int i = 3; i <= n; i++)
            {
                count[i] = count[i - 1] + count[i - 2] + count[i - 3];
            }

            return count[n];
        }
    }
}
