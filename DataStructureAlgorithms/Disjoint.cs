using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithms
{
    public class Disjoint
    {
        private int[] size = null;

        public static void PrintNumOfFriends(List<Tuple<int, int>> friends, int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                int cnt = 0;
                foreach(var relationship in friends)
                {
                    if (arr[i] == relationship.Item1 || arr[i] == relationship.Item2)
                        cnt++;
                }
                Console.Write(" " + cnt);
            }
        }

        Disjoint(int[] arr, int n)
        {
            size = new int[n];

            for(int i = 0; i < n; i++)
            {
                arr[i] = i;
                size[i] = 1;
            }
        }

        public static int root(int[] arr, int i)
        {
            while(arr[i] != i)
            {
                i = arr[i];
            }
            return i;
        }

        public static void union(int[] arr, int a, int b)
        {
            int root_A = root(arr, a);
            int root_B = root(arr, b);
            arr[root_A] = root_B;       //Setting parent of root(a) as root(b)
        }

        public void weightedUnion(int[] arr, int[] size, int a, int b)
        {
            int root_A = root(arr, a);
            int root_B = root(arr, b);

            if (size[root_A] < size[root_B])
            {
                arr[root_A] = arr[root_B];
                size[root_B] += size[root_A];
            }
        }

        public static bool find(int[] arr, int a, int b)
        {
            if (root(arr, a) == root(arr, b))
                return true;
            else
                return false;
        }
    }
}
