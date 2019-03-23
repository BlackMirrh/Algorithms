using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    public class SubsetSum
    {
        public static bool IsSubsetSum(int[] set, int n, int sum)
        {   
            for(int i = 0; i < n - 1; i++)
            {
                if (set[i] >= sum)
                    continue;

                for (int j = i + 1; j < n; j++)
                {
                    if (sum - set[i] == set[j])
                    {
                        Console.WriteLine("There is a subset ({0}, {1}) with sum {2} ", set[i], set[j], sum);
                        return true;
                    }
                        
                }   
            }

            return false;
        }

        public static bool IsSubsetSumDP(int[] set, int n, int sum)
        {
            // The value of subset[i][j] will be true if there is a subset of set[0..j-1] with sum equal to i
            bool[,] subset = new bool[sum + 1, n + 1];
            
            // If sum is 0, then answer is true
            for (int i = 0; i <= n; i++)
            {
                subset[0, i] = true;
            }

            // If sum is not 0 and set is empty, then answer is false
            for (int i = 1; i <= sum; i++)
            {
                subset[i, 0] = false;
            }

            // Fill the subset table in bottom up manner
            for (int i = 1; i <= sum; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    subset[i, j] = subset[i, j - 1];
                    if (i >= set[j - 1])
                        subset[i, j] = subset[i, j] || subset[i - set[j - 1], j - 1];
                }
            }

            return subset[sum,n];
        }
    }
}
