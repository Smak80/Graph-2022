using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_2022
{
    public class Graph
    {
        private List<Vertex> v = new();
        private List<Edge> e = new();
        public int VertexCount => v.Count;
        public Graph(double[,]matrix)
        {
            createGraph(matrix);
        }

        private void createGraph(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                v.Add(new Vertex(this));
            }

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = i + 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0) e.Add(new Edge(v[i], v[j], matrix[i,j]));
                }
            }
        }
    }
}
