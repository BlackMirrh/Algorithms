using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithms
{
    public class Traversal
    {
        internal Node root;
        public void InorderTraversal()
        {
            if (root == null)
                return;

            Stack<Node> s = new Stack<Node>();
            Node curr = root;

            // traverse the tree
            while (curr != null || s.Count > 0)
            {
                // Reach the left most Node of the curr Node
                while (curr != null)
                {
                    // place pointer to a tree node on the stack before traversing the node's left subtree
                    s.Push(curr);
                    curr = curr.left;
                }

                // Current must be NULL at this point
                curr = s.Pop();

                Console.Write(curr.value + " ");

                // we have visited the node and its left subtree. Now, it's right subtree's turn
                curr = curr.right;
            }
        }
    }
}
