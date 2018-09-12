using System;
using System.Diagnostics;

namespace DataStructureAlgorithms
{
    class Node
    {
        public int value;
        public Node left;
        public Node right;
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

        public Node GetNode(Node node, int searchTarget)
        {
            if(node.value == searchTarget)
            {
                return node;
            }
            else if (searchTarget < node.value)
            {
                return GetNode(node.left, searchTarget);
            }
            else
            {
                return GetNode(node.right, searchTarget);
            }
        }     
    }      
}
