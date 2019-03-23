using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAlgorithms
{
    public static class FindMissing
    {
        public static int[] FindMissingIndex(int[] arr, int max)
        {
            return Enumerable.Range(0, max).Except(arr).ToArray();
        }

        public static int FindMissingValue(int[] arr, int n)
        {
            int total = (n + 2) * ((n + 1) / 2);

            for(int i = 0; i < n; i++)
            {
                total -= arr[i];
            }
            return total;
        }

        public static int FindMissingBinaryTree(int[] arr, int n)
        {
            int a = 0, b = n - 1;
            int mid = 0;

            while ((b - a) > 1)
            {
                mid = (a + b) / 2;

                if ((arr[a] - a) != (arr[mid] - mid))
                    b = mid;
                else if ((arr[b] - b) != (arr[mid] - mid))
                    a = mid;
            }

            return (arr[mid] + 1);
        }
    }

    public class Node
    {
        int val;

        Node left = new Node();
        Node right = new Node();
    }
}
