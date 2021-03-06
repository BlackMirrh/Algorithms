﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Graph<T>
    {
        public Graph() { }
        public Graph(IEnumerable<T> vertices, IEnumerable<Edge<T>> edges)
        {
            foreach (var vertex in vertices)
                AddVertex(vertex);

            foreach (var edge in edges)
                AddEdge(edge);
        }

        public Dictionary<T, LinkedList<T>> AdjacencyList { get; } = new Dictionary<T, LinkedList<T>>();

        public void AddVertex(T vertex)
        {
            AdjacencyList[vertex] = new LinkedList<T>();
        }

        public void AddEdge(Edge<T> edge)
        {
            AdjacencyList[edge.src].AddLast(edge.dest);
        }       
    }

    public class Edge<T>
    {
        public T src;
        public T dest;
    }
}
