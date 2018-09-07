using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAlgorithms
{
    public static class MergeArray
    {
        public static int[] MergeArrayElement(int[] arr1, int[] arr2)
        {
            int[] mergedArray = arr1.Concat(arr2).ToArray();
            Array.Sort(mergedArray);
            return mergedArray;
        }

        public static int[] MergeArrays(int[] x, int[] y)
        {

            int[] mergedSortedArray = new int[x.Length + y.Length];
            for (var i = x.Length - 1; i >= 0; --i)
            {
                var counter = y.Length - 1;
                do
                {
                    if (y[counter] > x[i] && y[counter] > 0)
                        mergedSortedArray[counter + 1] = y[counter];
                    else if (y[counter] <= x[i] && y[counter] > 0)
                        break;

                    --counter;
                }
                while (counter >= 0);

                mergedSortedArray[counter + 1] = x[i];
            }

            return mergedSortedArray;
        }

        public static void merge(int[] arr1, int[] arr2, int usedIndex)
        {
            int longused = usedIndex;
            int shortarr = arr2.Length - 1;
            while (shortarr >= 0 && longused >= 0)
            {
                if (arr2[shortarr] > arr1[longused])
                {
                    arr1[shortarr + longused + 1] = arr2[shortarr];
                    shortarr--;
                }
                else
                {
                    arr1[shortarr + longused + 1] = arr1[longused];
                    longused--;
                }
            }
            while (shortarr >= 0)
            {
                arr1[shortarr] = arr2[shortarr];
                shortarr--;
            }
        }
    }
}    