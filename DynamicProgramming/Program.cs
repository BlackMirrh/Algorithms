using System;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 10;
            //Fibonacci fibonacci = new DynamicProgramming.Fibonacci();
            //fibonacci.initialize();
            //Console.WriteLine("Fibonacci number is " + fibonacci.fib(n));

            //String s1 = "AGGTAB";
            //String s2 = "GXTXAYB";

            //char[] X = s1.ToCharArray();
            //char[] Y = s2.ToCharArray();

            //int m = X.Length;
            //int n = Y.Length;

            //Console.WriteLine("Length of LCS is " + LCS.GetLCS(X, Y, m, n));

            //Console.WriteLine("The longest increasing subsequence is " + LIS.GetLIS(arr));

            //int[] arr = { 3, 1, 4, 2, 2, 1 };
            //int n = arr.Length;

            //Console.WriteLine("The minimum difference between 2 subsets is " + SubsetMinDiff.findMin(arr, n));

            //int n = 5;
            //Console.WriteLine("Number of ways to cover a distance : " + NumOfCoverDistance.Distance(n));

            //int[] set = { 3, 34, 4, 12, 5, 2 };
            //Console.WriteLine(SubsetSum.IsSubsetSumDP(set, set.Length, 9));

            //int[] arr1 = { 8, 15, 3, 7 };
            //int n = arr1.Length;
            //Console.WriteLine("" + OptimalGame.optimalStrategyOfGame(arr1, n));

            //int[] arr2 = { 2, 2, 2, 2 };
            //n = arr2.Length;
            //Console.WriteLine("" + OptimalGame.optimalStrategyOfGame(arr2, n));

            //int[] arr3 = { 20, 30, 2, 2, 2, 10 };
            //n = arr3.Length;
            //Console.WriteLine("" + OptimalGame.optimalStrategyOfGame(arr3, n));

            int[] val = new int[] { 60, 100, 120 };
            int[] wt = new int[] { 10, 20, 30 };
            int W = 50;
            int n = val.Length;

            Console.WriteLine(KnapSack.knapSackDP(W, wt, val, n));

            Console.ReadLine();
        }
    }
}
