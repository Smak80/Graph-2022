using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_2022
{
    public class Vertex
    {
        public int Number { get; }
        public Graph Owner { get; init; }

        public Vertex(Graph owner)
        {
            Owner = owner;
            Number = owner.VertexCount + 1;
        }

        public static bool operator ==(Vertex v1, Vertex v2)
        {
            return v1.Owner == v2.Owner && v1.Number == v2.Number;
        }

        public static bool operator !=(Vertex v1, Vertex v2)
        {
            return !(v1 == v2);
        }
    }
}
