using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DataStructureAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 10;
            int[] input = { 2, 45, 7, 3, 5, 1, 8, 9 };
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            
            for(int i = 0; i < input.Length; i++)
            {
                if(pairs.ContainsKey(input[i]))
                {
                    Console.WriteLine(input[i] + ", " + pairs[input[i]]);
                }
                else
                {
                    pairs[k - input[i]] = input[i];
                }
            }

            //Node root = null;
            //Tree bst = new Tree();
            //int SIZE = 10000;
            //int[] a = new int[SIZE];

            //Console.WriteLine("Generating random array with {0} values...", SIZE);

            //Random random = new Random();

            //Stopwatch watch = Stopwatch.StartNew();

            //for (int i = 0; i < SIZE; i++)
            //{
            //    a[i] = random.Next(10000);
            //}

            //watch.Stop();

            //Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            //Console.WriteLine();
            //Console.WriteLine("Filling the tree with {0} nodes...", SIZE);

            //watch = Stopwatch.StartNew();

            //for (int i = 0; i < SIZE; i++)
            //{
            //    root = bst.Insert(root, a[i]);
            //}

            //watch.Stop();

            //Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            //Console.WriteLine();
            ////Console.WriteLine("Traversing all {0} nodes in tree...", SIZE);
            ////watch = Stopwatch.StartNew();
            ////bst.Traverse(root);
            ////watch.Stop();
            ////Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);

            //Node node = bst.GetMaxNode(root);

            //Console.WriteLine("Max value : " + node.value);

            //node = bst.GetMinNode(root);

            //Console.WriteLine("Min value : " + node.value);

            Console.ReadKey();
        }
    }
}
