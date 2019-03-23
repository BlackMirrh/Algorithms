using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class DepthFirst
    {
        public static HashSet<T> DFS<T>(Graph<T> graph, T start)
        {
            var visited = new HashSet<T>();

            if (!graph.AdjacencyList.ContainsKey(start))
                return visited;

            var stack = new Stack<T>();
            stack.Push(start);

            while(stack.Count > 0)
            {
                var vertex = stack.Pop();

                if (visited.Contains(vertex))
                    continue;
                visited.Add(vertex);

                foreach (var neighbor in graph.AdjacencyList[vertex])
                    if (!visited.Contains(neighbor))
                        stack.Push(neighbor);
            }


            return visited;
        }

        public static HashSet<T> DFS<T>(Graph<T> graph, T start, Action<T> preVisit = null)
        {
            var visited = new HashSet<T>();

            if (!graph.AdjacencyList.ContainsKey(start))
                return visited;

            var stack = new Stack<T>();
            stack.Push(start);

            while (stack.Count > 0)
            {
                var vertex = stack.Pop();

                if (visited.Contains(vertex))
                    continue;

                if (preVisit != null)
                    preVisit(vertex);

                visited.Add(vertex);

                foreach (var neighbor in graph.AdjacencyList[vertex])
                    if (!visited.Contains(neighbor))
                        stack.Push(neighbor);
            }


            return visited;
        }     

        public static bool DetectCycleDFS<T> (Graph<T> graph, T start)
        {
            HashSet<T> visited = new HashSet<T>();
            Stack<T> stack = new Stack<T>();
            if (!graph.AdjacencyList.ContainsKey(start))
                return false;

            visited.Add(start);
            stack.Push(start);

            foreach (var key in graph.AdjacencyList.Keys)
            {
                if (!visited.Contains(key))
                    visited.Add(key);   

                foreach (var child in graph.AdjacencyList[key])
                {
                    if (stack.Contains(child) && visited.Contains(child))
                        return true;
                    else if (!visited.Contains(child) && !stack.Contains(child))
                        stack.Push(child);
                } 
            }
                    
            return false;
        }

        private int V;
        private LinkedList<int>[] adj;

        public DepthFirst(int v)
        {
            V = v;
            adj = new LinkedList<int>[v];
            for (int i = 0; i < v; ++i)
                adj[i] = new LinkedList<int>();
        }

        public void addEdge(int v, int w)
        {
            adj[v].AddLast(w);
            adj[w].AddLast(v);
        }

        bool isCyclicUtil(int v, bool[] visited, int parent)
        {
            visited[v] = true;

            IEnumerable<int> it = adj[v].AsEnumerable();
            foreach(var i in it)
            {
                if (!visited[i])
                {
                    if (isCyclicUtil(i, visited, v))
                        return true;
                }
                else if (i != parent)
                    return true;
            }

            return false;
        }

        public bool isCyclic()
        {
            bool[] visited = new bool[V];
            for(int i = 0; i < V; i++)
            {
                visited[i] = false;
            }

            for (int u = 0; u < V; u++)
                if (!visited[u])
                    if (isCyclicUtil(u, visited, -1))
                        return true;

            return false;
        }
    }
}
