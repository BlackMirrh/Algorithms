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

                //if minPos no longer equals i, it ssselecP a smaller value existed so a swap must take place to sort the values
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
                QuickSort(elements, left, j);
            }

            if (i < right)
            {
                QuickSort(elements, i, right);
            }
        }

        public static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }

            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while(left.Count > 0 || right.Count > 0)
            {
                if(left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if(left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;   
        }

        private static int getMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                    max = arr[i];
            }
            return max;
        }

        public static void countingSort(int[] arr, int n, int exp)
        {
            int[] output = new int[n];
            int i;
            int[] count = new int[10];

            //initializing all elements of count to 0
            for (i = 0; i < 10; i++)
                count[i] = 0;

            // Store count of occurrences in count[]
            for (i = 0; i < n; i++)
                count[(arr[i] / exp) % 10]++;

            // Change count[i] so that count[i] now contains actual position of this digit in output[]
            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];

            // Build the output array
            for (i = n -1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

            // Copy the output array to arr[], so that arr[] now contains sorted numbers according to current digit
            for (i = 0; i < n; i++)
                arr[i] = output[i];
        }

        public static void radixSort(int[] arr, int n)
        {
            // Find the maximum number to know number of digits
            int m = getMax(arr);

            // Do counting sort for every digit. Note that instead of passing digit number, exp is passed. 
            // exp is 10^i where i is current digit number
            for (int exp = 1; m / exp > 0; exp *= 10)
                countingSort(arr, n, exp);
        }
    }
}
