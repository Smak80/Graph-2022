namespace Graph_2022
{
    public partial class Form1 : Form
    {
        private Loader l = new Loader("data.csv");
        private Graph gr;
        private GraphPainter gp;
        public Form1()
        {
            InitializeComponent();
            var d = l.Load();
            gr = new Graph(d);
            gp = new GraphPainter(gr);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            gp.Paint(e.Graphics);
        }
    }
}