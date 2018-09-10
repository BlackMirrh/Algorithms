using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAlgorithms
{
    public static class FizzBuzz
    {
        public static void PrintFizzBuzz(int n)
        {
            StringBuilder sb = new StringBuilder();

            for(int i = 1; i <= n; i++)
            {
                if ((i % 3) == 0 && (i % 5) == 0)
                    sb.Append("FizzBuzz");
                else if ((i % 3) == 0)
                    sb.Append("Fizz");
                else if ((i % 5) == 0)
                    sb.Append("Buzz");
                else
                    sb.Append(i.ToString());
            }

            Console.WriteLine(sb);
        }
    }
}
