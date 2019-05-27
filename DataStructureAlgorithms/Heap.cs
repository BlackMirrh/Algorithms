using System;
using System.Collections.Generic;   
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithms
{
    class HeapNode
    {
        private int nodeItem;
        public HeapNode(int value)
        {
            nodeItem = value;
        }

        public int getvalue()
        {
            return nodeItem;
        }

        public void setvalue(int id)
        {
            nodeItem = id;
        }
    }

    class Heap
    {
        private HeapNode[] heapArray;
        private int maxSize;
        private int currentSize;
        public Heap(int maxHeapSize)
        {
            maxSize = maxHeapSize;
            currentSize = 0;
            heapArray = new HeapNode[maxSize];
        }

        public bool IsEmpty()
        {
            return currentSize == 0;
        }

        public bool Insert(int value)
        {
            if (currentSize == maxSize)
                return false;
            HeapNode newNode = new HeapNode(value);
            heapArray[currentSize] = newNode;
            CascadeUp(currentSize++);
            return true;
        }

        public void CascadeUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapNode bottom = heapArray[index];
            while (index > 0 && heapArray[parent].getvalue() < bottom.getvalue())
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }

        public HeapNode Remove()
        {
            HeapNode root = heapArray[0];
            heapArray[0] = heapArray[--currentSize];
            CascadeDown(0);
            return root;
        }

        public void CascadeDown(int index)
        {
            int largerChild;
            HeapNode top = heapArray[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = 2 * index + 2;

                if (rightChild < currentSize && heapArray[leftChild].getvalue() < heapArray[rightChild].getvalue())
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if (top.getvalue() >= heapArray[largerChild].getvalue())
                    break;
                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }
            heapArray[index] = top;
        }

        public bool HeapIncreaseDecreaseKey(int index, int newValue)
        {
            if (index < 0 || index >= currentSize)
                return false;
            int oldValue = heapArray[index].getvalue();
            heapArray[index].setvalue(newValue);
            if (oldValue < newValue)
                CascadeUp(index);
            else
                CascadeDown(index);
            return true;
        }

        public void DisplayHeap()
        {
            Console.WriteLine();
            Console.Write("Elements of the Heap Array are : ");
            for (int m = 0; m < currentSize; m++)
                if (heapArray[m] != null)
                    Console.Write(heapArray[m].getvalue() + " ");
                else
                    Console.Write("-- ");
            Console.WriteLine();
            int emptyLeaf = 32;
            int itemsPerRow = 1;
            int column = 0;
            int j = 0;
            String separator = "...............................";
            Console.WriteLine(separator + separator);
            while (currentSize > 0)
            {
                if (column == 0)
                    for (int k = 0; k < emptyLeaf; k++)
                        Console.Write(' ');
                Console.Write(heapArray[j].getvalue());
                if (++j == currentSize)
                    break;
                if (++column == itemsPerRow)
                {
                    emptyLeaf /= 2;
                    itemsPerRow *= 2;
                    column = 0;
                    Console.WriteLine();
                }
                else
                    for (int k = 0; k < (emptyLeaf * 2 - 2); k++)
                        Console.Write(' ');
            }
            Console.WriteLine("\n" + separator + separator);
        }
    }
}
