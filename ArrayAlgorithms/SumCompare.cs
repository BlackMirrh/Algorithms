using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAlgorithms
{
    public static class SumCompare
    {
        public static bool IsSumToArray(int[] arr)
        {
            if (arr == null)
                throw new Exception("Invalid argument");

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int sum = arr[i] + arr[j];
                    if (arr.Contains(sum))
                    {
                        return true;
                    }

                }
            }

            return false;
        }
    }
}
