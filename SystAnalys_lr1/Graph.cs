using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystAnalys_lr1
{
    internal class Graph
    {
        List<Edge> edges = new List<Edge>();

        public void addEdge(Edge e)
        {
            edges.Add(e);
        }

        public void removeEdge(Edge e)
        {
            edges.Remove(e);
        }

        public List<Edge> getEdges() {  return edges; }

        public HashSet<Vertex> getVertices() {
            HashSet<Vertex> vertices = new HashSet<Vertex>();
            foreach (Edge e in edges)
            {
                vertices.Add(e.v1);
                vertices.Add(e.v2);
            }
            return vertices;
        }

        public Edge GetEdge(int edge)
        {
            return edges[edge];
        }


    }
}
