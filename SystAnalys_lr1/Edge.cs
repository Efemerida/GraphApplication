using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystAnalys_lr1
{
    internal class Edge
    {
        public Vertex v1 {  get; set; }
        public Vertex v2 { get; set; }

        public Edge(Vertex v1, Vertex v2) {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}
