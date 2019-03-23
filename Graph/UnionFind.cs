using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class UnionFind
    {
        int V, E;

        public Edges[] edge;

        public UnionFind()
        { }

        public UnionFind(int v, int e)
        {
            V = v;
            E = e;
            edge = new Edges[e];
            for(int i = 0; i < e; i++)
            {
                edge[i] = new Edges();
            }
        }

        int find(int[] parent, int i)
        {
            if (parent[i] == -1)
                return i;
            return find(parent, parent[i]);
        }

        void Union(int[] parent, int x, int y)
        {
            int xset = find(parent, x);
            int yset = find(parent, y);
            parent[xset] = yset;
        }

        public bool isCycle(UnionFind uf)
        {
            int[] parent = new int[uf.V];

            for (int i = 0; i < uf.V; ++i)
                parent[i] = -1;

            for (int i = 0; i < uf.E; ++i)
            {                                     
                int x = uf.find(parent, uf.edge[i].src);
                int y = uf.find(parent, uf.edge[i].dest);

                if (x == y)
                    return true;

                uf.Union(parent, x, y);
            }
            return false;
        }

    }

    public class Edges
    {
        public int src, dest;
    }

}
