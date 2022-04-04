using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_2022
{
    public class Path : Graph
    {
        private Stack<Vertex> vertices = new();

        public List<Vertex> Vertices
        {
            get
            {
                var r = new List<Vertex>();
                while (vertices.Count > 0)
                {
                    r.Add(vertices.Pop());
                }

                return r;
            }
        }
        public int Length { get; private set; }

        public Path(Graph g) : base(g)
        {
            
        }
    }
}
