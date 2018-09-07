﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAlgorithms
{
    public static class FindMissing
    {
        public static int[] FindMissingIndex(int[] arr, int max)
        {
            return Enumerable.Range(0, max).Except(arr).ToArray();
        }

        public static int FindMissingValue(int[] arr, int n)
        {
            int total = (n + 2) * ((n + 1) / 2);

            for(int i = 0; i < n; i++)
            {
                total -= arr[i];
            }
            return total;
        }
    }
}
