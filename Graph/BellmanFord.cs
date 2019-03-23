using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class BellmanFord
    {
        public class Edge
        {
            public int src { get; set; }
            public int dest { get; set; }
            public int weight { get; set; }
        }

        public class Graph
        {
            public int V, E;

            public Edge[] edge; 
        }

        public Graph CreateGraph(int V, int E)
        {
            Graph graph = new Graph();
            graph.V = V;
            graph.E = E;
            graph.edge = new Edge[E];
            return graph;
        }

        public bool IsNegCycleBellmanFord(Graph graph, int src)
        {
            int V = graph.V;
            int E = graph.E;
            int[] dist = new int[V];

            // Step 1 : Initialize distances
            for (int i = 0; i < V; i++)
                dist[i] = int.MaxValue;

            dist[src] = 0;

            // Step 2 : Relax all edges
            for (int i = 1; i < V - 1; i++)
            {
                for(int j = 0; j < E; j++)
                {
                    int u = graph.edge[j].src;
                    int v = graph.edge[j].dest;
                    int weight = graph.edge[j].weight;

                    if (dist[u] != int.MaxValue && dist[u] + weight < dist[v])
                        dist[v] = dist[u] + weight; 
                }
            }

            return false;
        }

    }
}

    
