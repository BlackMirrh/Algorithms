using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;

            HanoiTower.TowerOfHanoi(n, 'A', 'C', 'B');
            //Console.WriteLine(SumOfDigits.GetSumOfDigits(156));

            //Console.WriteLine(DecimalToBinary.BinaryConversion(75));
            Console.ReadLine();
        }
    }
}
