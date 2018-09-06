using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 9, 7, 3, 8, 2, 1, 4, 6 };

            Console.WriteLine(SumCompare.IsSumToArray(arr));

            //RotateArray.Rotate(arr, 2);

            //foreach(int i in arr)
            //{
            //    Console.Write("{0}, ", i);
            //}

            Console.ReadLine();
        }
    }
}
