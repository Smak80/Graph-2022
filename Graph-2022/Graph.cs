using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_2022
{
    public class Graph
    {
        private List<Vertex> _v = new();
        private List<Edge> _e = new();
        public int VertexCount => _v.Count;
        public Graph(double[,]matrix)
        {
            createGraph(matrix);
        }

        protected Graph(Graph g)
        {
            _v = g._v;
            _e = g._e;
        }

        private void createGraph(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                _v.Add(new Vertex(this));
            }

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = i + 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0) _e.Add(new Edge(_v[i], _v[j], matrix[i,j]));
                }
            }
        }
    }
}
