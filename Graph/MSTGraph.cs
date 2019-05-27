using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class MSTGraph
    {
        public class MSTEdge : IComparable  // Comparer<MSTEdge>
        {
            public int src, dest, weight;
                                       
            public int CompareTo(object obj)  //MSTEdge destEdge
            {
                if(obj is MSTEdge)
                    return this.weight.CompareTo((obj as MSTEdge).weight);
                throw new ArgumentException("Object is not an Edge.");
            } 
        }

        class subset
        {
            public int parent, rank;
        }

        int V, E;
        public MSTEdge[] edge;

        public MSTGraph(int v, int e)
        {
            V = v;
            E = e;
            edge = new MSTEdge[E];
            for (int i = 0; i < e; ++i)
                edge[i] = new MSTEdge();
        }

        // A utility function to find set of an element i (uses path compression techique)
        int find(subset[] subsets, int i)
        {
            // find root and make root as parent of i (path compression)
            if (subsets[i].parent != i)
                subsets[i].parent = find(subsets, subsets[i].parent);
            return subsets[i].parent;
        }

        // A function that does union of two sets of x and y (uses union by rank)
        void Union(subset[] subsets, int x, int y)
        {
            int xroot = find(subsets, x);
            int yroot = find(subsets, y);

            // Attach smaller rank tree under root of high rank tree (union by rank)
            if (subsets[xroot].rank < subsets[yroot].rank)
                subsets[xroot].parent = yroot;
            else if (subsets[xroot].rank > subsets[yroot].rank)
                subsets[yroot].parent = xroot;

            // If ranks are same, then make one as root and increment its rank by one
            else
            {
                subsets[yroot].parent = xroot;
                subsets[xroot].rank++;
            }
        }

        // The main function to construct MST using Kruskal's algorithm
        public void KruskalMST()
        {
            MSTEdge[] result = new MSTEdge[V]; // This will store the result MST
            int e = 0;  // An index variable, used for result[]
            int i = 0;  // An index variable, used for stored edges
            for (i = 0; i < V; ++i)
                result[i] = new MSTEdge();

            // Step 1: Sort all the edges in non-decreasing order of their weight.
            // If we are not allowed to change the given graph, we can create a copy of array of edges
            //Array.Sort(edge, delegate (MSTEdge edge1, MSTEdge edge2) {
            //    return edge1.weight.CompareTo(edge2.weight);
            //});
            Array.Sort(edge);

            // Allocate memory for creating V subsets
            subset[] subsets = new subset[V];
            for (i = 0; i < V; ++i)
                subsets[i] = new subset();

            // Create V subsets with single elements
            for (int v = 0; v < V; ++v)
            {
                subsets[v].parent = v;
                subsets[v].rank = 0;
            }

            i = 0;  // Index used to pick next edge

            // Number of edges to be taken is equal to V - 1
            while (e < V - 1)
            {
                // Step 2 : Pick the smallest edge. And increment the index for next iteration
                MSTEdge nextEdge = new MSTEdge();
                nextEdge = edge[i++];

                int x = find(subsets, nextEdge.src);
                int y = find(subsets, nextEdge.dest);

                // If including this edge doesn't cause cycle, include it in the result and increment the index of result for next edge
                if (x != y)
                {
                    result[e++] = nextEdge;
                    Union(subsets, x, y);
                }
                // Else discard the nextEdge;
            }

            Console.WriteLine("Following are the edges in the constructed MST");

            for (i = 0; i < e; ++i)
                Console.WriteLine(result[i].src + " -- " + result[i].dest + " == " + result[i].weight);
        }

    }
    //public class MST
    //{
        //public int KruskalMST()
        //{
            
            //KRUSKAL(G):            with disjoint-set data structure 
            //1 A = ∅
            //2 foreach v ∈ G.V:
            //3    MAKE - SET(v)
            //4 foreach (u, v) in G.E ordered by weight(u, v), increasing:
            //5    if FIND - SET(u) ≠ FIND - SET(v):
            //6       A = A ∪ { (u, v)}
            //7       UNION(u, v)
            //8 return A
            
        
        //return 0;
        //}
    //}
}
