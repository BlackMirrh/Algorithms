using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    public class Fibonacci
    {
        static int MAX = 100;
        static int NIL = -1;
        static int[] lookup = new int[MAX];

        public void initialize()
        {
            for (int i = 0; i < MAX; i++)
                lookup[i] = NIL;
        }

        // Memoization
        //public int fib(int n)
        //{
        //    if(lookup[n] == NIL)
        //    {
        //        if (n <= 1)
        //            lookup[n] = n;
        //        else
        //            lookup[n] = fib(n - 1) + fib(n - 2);
        //    }
        //    return lookup[n];
        //}

        // Tabulation
        public int fib(int n)
        {
            int[] f = new int[n + 1];
            f[0] = 0;
            f[1] = 1;
            for (int i = 2; i <= n; i++)
                f[i] = f[i - 1] + f[i - 2];
            return f[n];
        }
    }
}
