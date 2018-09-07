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
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 10, 10,11,12,13,14,15,16,17,18,19,20 };

            Console.WriteLine(Duplicate.IsDuplicated(arr));

            //MoveZeroToEnd.MoveZeroToEndArray(arr);

            //SwapMinMax.SwapMinMaxElement(arr);

            //Console.WriteLine(SumArray.SumArrayElements(arr));

            //int[] arr2 = { 10, 13, 15, 17, 19 };

            //int[] result = FindMissing.FindMissingIndex(arr, 50);

            //Console.WriteLine(FindMissing.FindMissingValue(arr, 19));

            //Console.WriteLine(FindMajority.FindMajorityElement(arr));
            //int pivot = (arr.Length + arr2.Length) / 2;
            //MergeArray.merge(arr, arr2, pivot);

            //Console.WriteLine(SumCompare.IsSumToArray(arr));

            //RotateArray.Rotate(arr, 2);

            //Array.Reverse(arr);

            //foreach (int i in arr)
            //{
            //    Console.Write("{0}, ", i);
            //}

            Console.ReadLine();
        }
    }
}
