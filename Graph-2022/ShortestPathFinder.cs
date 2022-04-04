using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_2022
{
    public class ShortestPathFinder
    {
        private Graph _graph;
        public ShortestPathFinder(Graph g)
        {
            _graph = g;
        }

        public Path GetShortestPath(Vertex from, Vertex to)
        {
            _graph[from].PathLength = 0;
            var currVertex = GetMinVertex();
            if (currVertex is not null)
            {
                var edges = _graph.GetEdgesFrom(currVertex);
                foreach (var edge in edges)
                {
                    update(edge.GetPairFor(currVertex), edge);
                }

                currVertex.Visited = true;
            }
        }

        private void update(Vertex v, Edge e)
        {
            var ln = e.GetPairFor(v).PathLength + e.Weight;
            if (!v.Visited && v.PathLength > ln)
            {
                v.PathLength = ln;
                v.PathFrom = e.GetPairFor(v);
            }
        }

        private Vertex? GetMinVertex()
        {
            throw new NotImplementedException();
        }
    }
}
