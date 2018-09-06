using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    public static class Sort
    {
        public static void BubbleSort(int[] arr)
        {
            bool swapped;

            do
            {
                swapped = false;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    // here we use the i for the position in the array
                    // So i is the first value to compare and i + 1 compares the adjacent value
                    // Once i is incremented at the end of this loop, we compare the next two sets of values, etc.
                    if (arr[i] > arr[i + 1])
                    {
                        // swap routine.  Could be a separate method as well but is used inline for simplicity here
                        // temp is used to hold the right value in the comparison so we don't lose it.  That value will be replaced in the next step
                        int temp = arr[i + 1];

                        // Here we replace the right value with the larger value that was on the left.   See why we needed the temp variable above?
                        arr[i + 1] = arr[i];

                        // Now we assign the value that is in temp, the smaller value, to the location that was just vacated by the larger number
                        arr[i] = temp;

                        // Indicate that we did a swap, which means we need to continue to check the remaining values.
                        swapped = true;
                    }
                }
            } while (swapped == true);
        }

        public static void QuickSort(int[] arr, int left, int right)
        {
            if(left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                    QuickSort(arr, left, pivot - 1);
                if (pivot + 1 < right)
                    QuickSort(arr, pivot + 1, right);
            }
        }

        private static int Partition(int[] arr, int left, int right )
        {
            int pivot = arr[left];

            while(true)
            {
                while (arr[left] < pivot)
                    left++;
                while (arr[right] > pivot)
                    right--;

                if (left < right)
                {
                    int tmp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = tmp;
                }
                else
                    return right;
            }
        }
    }
}
