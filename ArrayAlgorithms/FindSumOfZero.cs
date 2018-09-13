using SortAlgorithms;
using SearchAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAlgorithms
{
    class FindSumOfZero
    {
        public static void SumOfZero(int[] firstArr, int[] secondArr)
        {
            Sort.QuickSort(firstArr, 0, firstArr.Length - 1);
            Sort.QuickSort(secondArr, 0, secondArr.Length - 1);

            foreach(int i in firstArr)
            {
                int compare = i * -1;

                int idx = Search.BinarySearch(secondArr, compare, 0, secondArr.Length - 1);

                if(idx != -1)
                    Console.WriteLine("{0}, {1}", i, secondArr[idx]);
            }
        }

        public static void SumOfZeroInteration(int[] arr1, int[] arr2)
        {
            foreach(int i in arr1)
            {
                foreach(int j in arr2)
                {
                    if ((i + j) == 0)
                        Console.WriteLine("{0}, {1}", i, j);
                }
            }
        }
    }
}
