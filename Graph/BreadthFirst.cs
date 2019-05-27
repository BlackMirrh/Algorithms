using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public static class BreadthFirst
    {
        public static HashSet<T> BFS<T> (Graph<T> graph, T start)
        {
            var visited = new HashSet<T>();

            if (!graph.AdjacencyList.ContainsKey(start))
                return visited;

            var queue = new Queue<T>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                var vertex = queue.Dequeue();

                if (visited.Contains(vertex))
                    continue;

                visited.Add(vertex);

                foreach (var neighbor in graph.AdjacencyList[vertex])
                    if (!visited.Contains(neighbor))
                        queue.Enqueue(neighbor);
            }

            return visited;
        }

        public static HashSet<T> BFS<T>(Graph<T> graph, T start, Action<T> preVisit = null)
        {
            var visited = new HashSet<T>();

            if (!graph.AdjacencyList.ContainsKey(start))
                return visited;

            var queue = new Queue<T>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                var vertex = queue.Dequeue();

                if (visited.Contains(vertex))
                    continue;

                if (preVisit != null)
                    preVisit(vertex);

                visited.Add(vertex);

                foreach (var neighbor in graph.AdjacencyList[vertex])
                    if (!visited.Contains(neighbor))
                        queue.Enqueue(neighbor);
            }

            return visited;
        }

        public static Func<T, IEnumerable<T>> ShortestPathFunction<T>(Graph<T> graph, T start)
        {
            var previous = new Dictionary<T, T>();

            var queue = new Queue<T>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                var vertex = queue.Dequeue();

                foreach(var neighbor in graph.AdjacencyList[vertex])
                {
                    if (previous.ContainsKey(neighbor))
                        continue;

                    previous[neighbor] = vertex;
                    queue.Enqueue(neighbor);
                }
            }

            Func<T, IEnumerable<T>> shortestPath = v =>
            {
                var path = new List<T> { };

                var current = v;

                while (!current.Equals(start))
                {
                    path.Add(current);
                    current = previous[current];
                }

                path.Add(start);
                path.Reverse();

                return path;
            };

            return shortestPath;
        }

        
    }

    public class BFSGraph
    {
        private int V;
        private LinkedList<int> adj;

        public BFSGraph(int v)
        {
            V = v;
            adj = new LinkedList<int>(); 
        }

        public void addEdge(int v, int w)
        {
            adj.AddLast(w);
        }

        public void BFS(int s)
        {
            bool[] visited = new bool[V];

            LinkedList<int> queue = new LinkedList<int>();
            visited[s] = true;
            queue.AddLast(s);

            while (queue.Count != 0)
            {
                s = queue.First();
                Console.WriteLine(s + " ");

                foreach (int i in adj)
                {
                    int n = i;

                }
            }

            for (LinkedListNode<int> it = queue.First; it != null;)
            {
                int n = it.Value;
                Console.WriteLine(n + " ");

                LinkedListNode<int> next = it.Next;
                if (!visited[n])
                {
                    visited[n] = true;
                    queue.AddLast(n);
                }
                it = next;      
            }  
        }
    }
}
