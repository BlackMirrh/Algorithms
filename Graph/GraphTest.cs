using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class GraphTest<T>
    {
        public GraphTest() { }

        public GraphTest(IEnumerable<T> vertices, IEnumerable<EdgeTest<T>> edges)
        {
            foreach (var vertex in vertices)
                AddVertex(vertex);

            foreach (var edge in edges)
                AddEdge(edge);
        }

        Dictionary<T, LinkedList<T>> adjacencyList { get; } = new Dictionary<T, LinkedList<T>>();
        public void AddVertex(T vertex)
        {
            adjacencyList[vertex] = new LinkedList<T>();
        }

        public void AddEdge(EdgeTest<T> edge)
        {
            adjacencyList[edge.src].AddLast(edge.dest);
        }
    }

    public class EdgeTest<T>
    {
        public T src;
        public T dest;
    }
}
