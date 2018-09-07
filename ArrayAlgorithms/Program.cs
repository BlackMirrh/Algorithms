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
            int[] arr = { 5, 9, 7, 3, 8, 2, 1, 4, 6, 5, 0, 0, 0, 0, 0 };
            int[] arr2 = { 10, 13, 15, 17, 19 };

            //Console.WriteLine(FindMajority.FindMajorityElement(arr));
            int pivot = (arr.Length + arr2.Length) / 2;
            MergeArray.merge(arr, arr2, pivot);

            //Console.WriteLine(SumCompare.IsSumToArray(arr));

            //RotateArray.Rotate(arr, 2);

            //Array.Reverse(arr);

            foreach (int i in arr)
            {
                Console.Write("{0}, ", i);
            }

            Console.ReadLine();
        }
    }
}
