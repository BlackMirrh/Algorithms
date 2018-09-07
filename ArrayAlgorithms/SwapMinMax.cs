using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAlgorithms
{
    public static class SwapMinMax
    {
        public static void SwapMinMaxElement(int[] arr)
        {
            int minIdx = 0;
            int maxIdx = 0;

            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[minIdx])
                    minIdx = i;
                else if (arr[i] > arr[maxIdx])
                    maxIdx = i;
            }

            //Swap
            int tmp = arr[minIdx];
            arr[minIdx] = arr[maxIdx];
            arr[maxIdx] = tmp;
        }
    }
}
