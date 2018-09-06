using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 9, 7, 3, 8, 2, 1, 4, 6 };

            #region LinearSearch

            // declare an array of integers that will be used for searching
            int term = 6;
            int index = Search.LinearSearch(arr, term);

            if (index != -1)
            {
                Console.WriteLine($"Your search term was found at position {index}");
            }
            else
            {
                Console.WriteLine("Your search term was not found.");
            }

            #endregion


            #region BinarySearch
            // declare an array of integers that will be used for searching
            int searchTerm = 8;
            int result = Search.BinarySearch(arr, searchTerm, 0, arr.Length - 1);

            if (result != -1)
            {
                Console.WriteLine($"Search term found at index {result}.");
            }
            else
            {
                Console.WriteLine("Search term not found in the array.");
            }

            #endregion

            Console.ReadLine();
        }
    }
}
