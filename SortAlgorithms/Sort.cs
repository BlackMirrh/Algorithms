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

        public static void InsertionSort(int[] arr)
        {
            int newValue;

            for (int i = 1; i < arr.Length; i++)
            {
                newValue = arr[i];

                int j = i;

                while (j > 0 && arr[j - 1] > newValue)
                {
                    arr[j] = arr[j - 1];

                    j--;
                }
                arr[j] = newValue;
            }
        }

        public static void SelectionSort(int[] arr)
        {
            //minPos will  keep track of where the minimum value is located
            int minPos;

            // temp is used for the swapping of values for the sort
            int temp;

            // outer loop will be responsible for ensuring we have iterated over the entire array
            for (int i = 0; i < arr.Length - 1; i++)
            {
                //set minPos to the current counter value for traversing the array
                minPos = i;

                // inner loop will perform the comparisons between the min and the other values in the array
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minPos])
                    {
                        //minPos will keep track of the index that min is in, this is needed when a swap happens
                        minPos = j;
                    }
                }

                //if minPos no longer equals i, it indicates a smaller value existed so a swap must take place to sort the values
                if (minPos != i)
                {
                    temp = arr[i];
                    arr[i] = arr[minPos];
                    arr[minPos] = temp;
                }
            }
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

        public static void QuickSort<T>(T[] elements, int left, int right) where T : IComparable
        {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                    i++;

                while (elements[j].CompareTo(pivot) > 0)
                    j--;

                if (i <= j)
                {
                    IComparable temp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = (T)temp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                QuickSortComparable(elements, left, j);
            }

            if (i < right)
            {
                QuickSortComparable(elements, i, right);
            }
        }
    }
}
