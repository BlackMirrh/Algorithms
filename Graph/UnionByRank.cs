using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class UnionByRank
    {
        int V, E;

        public Edges[] edge;

        public UnionByRank()
        { }

        public UnionByRank(int v, int e)
        {
            V = v;
            E = e;
            edge = new Edges[e];
            for (int i = 0; i < e; i++)
            {
                edge[i] = new Edges();
            }
        }

        int find(subset[] subsets, int i)
        {
            if (subsets[i].parent != -1)
                subsets[i].parent = find(subsets, subsets[i].parent);
            return subsets[i].parent;
        }

        void Union(subset[] subsets, int x, int y)
        {
            int xroot = find(subsets, x);
            int yroot = find(subsets, y);

            if (subsets[xroot].rank < subsets[yroot].rank)
                subsets[xroot].parent = yroot;
            else if (subsets[yroot].rank < subsets[xroot].rank)
                subsets[yroot].parent = xroot;
            else
            {
                subsets[xroot].parent = yroot;
                subsets[yroot].rank++;
            }
        }

        public int isCycle(UnionByRank ur)
        {
            int V = ur.V;
            int E = ur.E;

            subset[] subsets = new subset[V];
            for(int v = 0; v < V; v++)
            {
                subsets[v] = new subset();
                subsets[v].parent = v;
                subsets[v].rank = 0;
            }

            for (int e = 0; e < E; e++)
            {
                int x = find(subsets, ur.edge[e].src);
                int y = find(subsets, ur.edge[e].dest);

                if (x == y)
                    return 1;
                Union(subsets, x, y);
            }
            return 0;
        }

    }

    public class subset
    {
        public int parent, rank;
    }
}
