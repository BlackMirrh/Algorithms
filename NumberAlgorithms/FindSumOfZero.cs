using SortAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAlgorithms
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
                
                foreach(int j in secondArr)
                {
                    if (compare == j)
                        Console.WriteLine("{0}, {1}", i, j);
                }
            }


        }
    }
}
