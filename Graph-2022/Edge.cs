using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_2022
{
    public class Edge
    {
        public double Weight { get; set; }
        private Vertex _v1;
        private Vertex _v2;
        //public List<Vertex> Vertices => new(){_v1, _v2};
        public Vertex V1 => _v1;
        public Vertex V2 => _v2;
        
        public Edge(Vertex v1, Vertex v2, double weight)
        {
            _v1 = v1;
            _v2 = v2;
            Weight = weight;
        }
        public bool ConnectedTo(Vertex v) => (v == _v1 || v == _v2);

        public Vertex? GetPairFor(Vertex v)
        {
            if (ConnectedTo(v))
            {
                return V1 == v ? V2 : V1;
            }
            return null;
        }
    }
}
