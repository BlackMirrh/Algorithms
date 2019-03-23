using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            //var vertices = new[] { 0, 1, 2, 3 };

            //List<Edge<int>> edges = new List<Edge<int>>();

            //Edge<int> edge = new Edge<int>();
            //edge.src = 0;
            //edge.dest = 1;

            //edges.Add(edge);

            //var graph = new Graph<int>(vertices, edges);

            //var edges = new[]{Tuple.Create(0, 1), Tuple.Create(0, 2),
            //    Tuple.Create(1, 2), Tuple.Create(2, 0), Tuple.Create(2, 3),
            //    Tuple.Create(3, 3)};

            //, Tuple.Create(5,7), Tuple.Create(5,8), Tuple.Create(5, 6), Tuple.Create(8, 9), Tuple.Create(9, 10)


            //var path = new List<int>();

            //Console.WriteLine(string.Join(", ", BreadthFirst.BFS(graph, 1, v => path.Add(v))));
            //# 1, 2, 3, 4, 5, 6, 7, 8, 9, 10    

            //Console.WriteLine(string.Join(", ", BreadthFirst.BFS(graph, 1)));
            //Console.WriteLine(string.Join(", ", path));
            //# 1, 2, 3, 4, 5, 6, 7, 8, 9, 10    

            //var startVertex = 1;
            //var shortestPath = BreadthFirst.ShortestPathFunction(graph, startVertex);
            //foreach (var vertex in vertices)
            //    Console.WriteLine("shortest path to {0,2}: {1}", vertex, string.Join(",", shortestPath(vertex)));

            //Console.WriteLine(string.Join(",", DepthFirst.DFS(graph, 1)));

            //Console.WriteLine(string.Join(",", DepthFirst.DFS(graph, 1, v => path.Add(v))));
            //Console.WriteLine(string.Join(",", path));

            //Console.WriteLine(DepthFirst.DetectCycleDFS(graph, 0));

            //int V = 3, E = 3;
            //UnionFind uf = new UnionFind(V, E);

            //uf.edge[0].src = 0;
            //uf.edge[0].dest = 1;

            //uf.edge[1].src = 1;
            //uf.edge[1].dest = 2;

            //uf.edge[2].src = 0;
            //uf.edge[2].dest = 2;

            //if (uf.isCycle(uf))
            //    Console.WriteLine("Graph contains cycle");
            //else
            //    Console.WriteLine("Graph doesn't contain cycle");

            /* Let us create the example graph discussed above */
            int[,] graph = new int[,]{  {0,  4, 0,  0,  0,  0, 0,  8, 0},
                                        {4,  0, 8,  0,  0,  0, 0, 11, 0},
                                        {0,  8, 0,  7,  0,  4, 0,  0, 2},
                                        {0,  0, 7,  0,  9, 14, 0,  0, 0},
                                        {0,  0, 0,  9,  0, 10, 0,  0, 0},
                                        {0,  0, 4, 14, 10,  0, 2,  0, 0},
                                        {0,  0, 0,  0,  0,  2, 0,  1, 6},
                                        {8, 11, 0,  0,  0,  0, 1,  0, 7},
                                        {0,  0, 2,  0,  0,  0, 6,  7, 0}};
            GFG t = new GFG();
            t.dijkstra(graph, 0);

            DepthFirst df = new DepthFirst(5);
            df.addEdge(1, 0);
            df.addEdge(0, 2);
            df.addEdge(2, 0);
            df.addEdge(0, 3);
            df.addEdge(3, 4);

            if (df.isCyclic())
                Console.WriteLine("Graph contains cycle");
            else
                Console.WriteLine("Graph doesn't contains cycle");

            DepthFirst df2 = new DepthFirst(3);
            df2.addEdge(0, 1);
            df2.addEdge(1, 2);
            if(df2.isCyclic())
                Console.WriteLine("Graph contains cycle");
            else
                Console.WriteLine("Graph doesn't contains cycle");

            Console.ReadLine();
        }       
    }
}
