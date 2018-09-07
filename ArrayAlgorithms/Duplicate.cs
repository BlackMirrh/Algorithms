using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAlgorithms
{
    public static class Duplicate
    {
        public static bool IsDuplicated(int[] arr)
        {
            for(int i =0; i < arr.Length - 1; i++)
            {
                for(int j = i +1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        return true;
                }
            }
            return false;
        }
    }
}
