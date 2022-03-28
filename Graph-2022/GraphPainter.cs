using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_2022
{
    public class GraphPainter
    {
        private Graph _graph;
        private int vertexSize = 30;
        public GraphPainter(Graph graph)
        {
            _graph = graph;
        }

        public void Paint(Graphics g)
        {
            //PaintEdges(g);
            PaintVertices(g);
        }

        private void PaintVertices(Graphics g)
        {
            var r = Rectangle.Ceiling(g.VisibleClipBounds);
            g.TranslateTransform(r.Width/2, r.Height/2);
            g.DrawEllipse(
                new Pen(Color.BlueViolet, 2), 
                -vertexSize / 2, 
                -r.Height / 2 + vertexSize / 2, 
                vertexSize,
                vertexSize
                );
        }
    }
}
