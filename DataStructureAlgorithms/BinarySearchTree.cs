using System;
using System.Diagnostics;

namespace DataStructureAlgorithms
{
    class Node
    {
        public int value;
        public Node left;
        public Node right;

        public Node()
        {

        }

        public Node(int item)
        {
            value = item;
            left = right = null;
        }
    }

    class Tree
    {
        public Node Insert(Node root, int v)
        {
            if(root == null)
            {
                root = new Node();
                root.value = v;
            }
            else if(v < root.value)
            {
                root.left = Insert(root.left, v);
            }
            else
            {
                root.right = Insert(root.right, v);
            }

            return root;
        }

        public void Traverse(Node root)
        {
            if (root == null)
            {
                return;
            }

            Traverse(root.left);
            Traverse(root.right);
        }

        public Node GetMinNode(Node node)
        {
            if (node.left == null)
                return node;
            else
                return GetMinNode(node.left);
        }

        public Node GetMaxNode(Node node)
        {
            if (node.right == null)
                return node;
            else
                return GetMaxNode(node.right);
        }
    }      
}
