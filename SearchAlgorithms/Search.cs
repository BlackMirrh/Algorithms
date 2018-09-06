using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    public class Search
    {
        public static int LinearSearch(int[] arr, int term)
        {
            // set up a loop to iterate over the elements in the array
            // because this is a linear search, we start at the beginning
            // of the array and work through the elements looking for the term
            for (int i = 0; i < arr.Length; i++)
            {
                // if we found a match, we can return the index in the array where the term is
                if (arr[i] == term)
                {
                    return i;
                }
            }

            // if the term is not found, we reach the end of the array
            // and as a result, we return -1 indicating that the term wasn't found
            // at a valid index in the array.
            return -1;
        }

        public static int BinarySearch(int[] arr, int key, int first, int last)
        {
            while (first <= last)
            {
                int mid = (first + last) / 2;

                if (key == arr[mid])
                {
                    return mid;
                }
                else if (key < arr[mid])
                {
                    last = mid - 1;
                }
                else
                {
                    first = mid + 1;
                }
            }
            return -1;
        }
    }
}
