using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAlgorithms
{
    public static class SumArray
    {
        public static int SumArrayElements(int[] arr)
        {
            int total = 0;

            foreach (int i in arr)
                total += i;
            return total;
        }
    }
}
