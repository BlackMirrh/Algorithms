using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAlgorithms
{
    public static class Fibonacci
    {
        public static int Fib(int n)
        {
            if (n <= 1)
                return n;
            return Fib(n - 1) + Fib(n - 2);
        }

        public static int NthFibonacci(int n)
        {
            return Fib(n - 1);
        }

        public static int CountWays(int s)
        {
            return Fib(s + 1);
        }
    }
}
