using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAlgorithms
{
    public static class MoveZeroToEnd
    {
        public static void MoveZeroToEndArray(int[] arr)
        {
            if (arr.Contains(0))
            {
                int zeroIdx = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 0)
                    {
                        zeroIdx = i;
                        break;
                    }
                }

                for (int z = zeroIdx; z < arr.Length - 1; z++)
                {
                    arr[z] = arr[z + 1];
                }

                arr[arr.Length - 1] = 0;
            }
        }
    }
}
