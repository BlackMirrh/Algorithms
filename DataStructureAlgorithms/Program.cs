﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DataStructureAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tuple<int, int>> friends = new List<Tuple<int, int>> { Tuple.Create(4, 3), Tuple.Create(2, 4), Tuple.Create(2, 3) };

            int[] arr = { 1, 2, 3, 4 };
            Disjoint.PrintNumOfFriends(friends, arr);

            Traversal t = new Traversal();
            t.root = new Node(1);
            t.root.left = new Node(2);
            t.root.right = new Node(3);
            t.root.left.left = new Node(4);
            t.root.left.right = new Node(5);
            t.InorderTraversal();

            //Node root = null;
            //Tree bst = new Tree();
            //int SIZE = 10000;
            //int[] a = new int[SIZE];

            //Console.WriteLine("Generating random array with {0} values...", SIZE);
            //int k = 10;
            //int[] input = { 2, 45, 7, 3, 5, 1, 8, 9 };
            //Dictionary<int, int> pairs = new Dictionary<int, int>();

            //for(int i = 0; i < input.Length; i++)
            //{
            //    if(pairs.ContainsKey(input[i]))
            //    {
            //        Console.WriteLine(input[i] + ", " + pairs[input[i]]);
            //    }
            //    else
            //    {
            //        pairs[k - input[i]] = input[i];
            //    }
            //}

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

            //Heap theHeap = new Heap(21);
            //theHeap.Insert(40);
            //theHeap.Insert(70);
            //theHeap.Insert(20);
            //theHeap.Insert(60);
            //theHeap.Insert(50);
            //theHeap.Insert(100);
            //theHeap.Insert(82);
            //theHeap.Insert(35);
            //theHeap.Insert(90);
            //theHeap.Insert(10);
            //theHeap.DisplayHeap();
            //Console.WriteLine("Inserting a new node with value 120");
            //theHeap.Insert(120);
            //theHeap.DisplayHeap();
            //Console.WriteLine("Removing max element");
            //theHeap.Remove();
            //theHeap.DisplayHeap();
            //Console.WriteLine("Changing root to 130");
            //theHeap.HeapIncreaseDecreaseKey(0, 130);
            //theHeap.DisplayHeap();
            //Console.WriteLine("Changing root to 5");
            //theHeap.HeapIncreaseDecreaseKey(0, 5);
            //theHeap.DisplayHeap();
            //Console.ReadLine();

            //HashTableTutorial.Test();

            Console.ReadKey();
        }
    }
}
