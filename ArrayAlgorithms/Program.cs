using System;
using System.Diagnostics;

namespace ArrayAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 13, 14, 15, 16, 17, 5, 0, 6, 7, 8, 10, -11,12,18,-19,-20, -21,-25,-23,-22,-24,-26,-27,-28,-29,-30};

            int[] arr2 = { -1, -2, -3, -4, -5, 12, 13, 14, 0, 6, -7, -8, -10, 11, 15, 16, 17, 18, 19, 20, 21, 25, 23, 22, 24, 26, 27, 28, 29, 30 };

            Stopwatch watch = new Stopwatch();

            watch.Start();
            FindSumOfZero.SumOfZero(arr1, arr2);
            watch.Stop();
            Console.WriteLine("Elapsed {0} milliseconds.", watch.ElapsedMilliseconds);


            watch.Start();
            FindSumOfZero.SumOfZeroInteration(arr1, arr2);
            watch.Stop();
            Console.WriteLine("Elapsed {0} milliseconds.", watch.ElapsedMilliseconds);

            //Console.WriteLine(Duplicate.IsDuplicated(arr));

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
