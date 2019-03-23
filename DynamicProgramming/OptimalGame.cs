using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    public class OptimalGame
    {
        //public static int optimalStrategyOfGame(int[] arr, int n)
        //{
        //    int maxValue = 0, i, j;
        //    int half = n / 2;

        //    //bool[] visited = new bool[n];
        //    //for(int i = 0; i < n; i++)
        //    //    visited[i] = false;

        //    for (i = 0, j = n - 1; i < half - 1; i++, j--)
        //    {
        //        int Vi = arr[i] + Math.Min(Math.Max(arr[i + 2], arr[j]), Math.Max(arr[i + 1], arr[j - 1]));
        //        int Vj = arr[j] + Math.Min(Math.Max(arr[i + 1], arr[j - 1]), Math.Max(arr[i], arr[j - 2]));
        //        maxValue = maxValue + Math.Max(Vi, Vj);
        //    }

        //    return maxValue;
        //}

        public static int optimalStrategyOfGame(int[] arr, int n)
        {
            int[,] table = new int[n, n];
            int gap, i, j, x, y, z;

            // Fill table using the formula. Note that the table is filled in diagonal fashion
            // from diagonal elements to table[0, n-1] which is the result.
            for (gap = 0; gap < n; ++gap)
            {
                for (i = 0, j = gap; j < n; ++i, ++j)
                {
                    // Here x is value of F(i+2, j), y is F(i+1, j-1) and z is F(i, j-2) in the formula
                    x = ((i + 2) <= j) ? table[i + 2, j] : 0;
                    y = ((i + 1) <= (j - 1)) ? table[i + 1, j - 1] : 0;
                    z = (i <= (j - 2)) ? table[i, j - 2] : 0;

                    table[i, j] = Math.Max(arr[i] + Math.Min(x, y), arr[j] + Math.Min(y, z));
                }
            }
            return table[0, n - 1];
        }
    }
}
