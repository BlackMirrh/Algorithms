using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 9, 7, 3, 8, 2, 1, 4, 6 };

            //SortedSet<int> sortedArr = new SortedSet<int>();
            //Console.WriteLine("============ SortedSet order ============");
            //foreach (int i in arr)
            //{
            //    sortedArr.Add(i);
            //}

            //foreach (var a in sortedArr)
            //{
            //    Console.WriteLine(a);
            //}

            //Sort.QuickSort(arr, 0, arr.Length - 1);
            //Console.WriteLine("============ Quick Sort ============");
            //foreach (var a in arr)
            //{
            //    Console.WriteLine(a);
            //}

            Sort.BubbleSort(arr);
            Console.WriteLine("============ Bubble Sort ============");
            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
        }
    }
}
