using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystAnalys_lr1
{
    public partial class MainForm : Form
    {

        List<Vertex> vertices;
        DrawGraph drawGraph;

        public MainForm()
        {
            InitializeComponent();
            vertices = new List<Vertex>();
            drawGraph = new DrawGraph(sheet.Width, sheet.Height);
            sheet.Image = drawGraph.GetBitmap();
        }

        private void sheet_MouseClick(object sender, MouseEventArgs e)
        {
            vertices.Add(new Vertex(e.X, e.Y));
            drawGraph.drawVertex(e.X, e.Y, vertices.Count.ToString());
            sheet.Image = drawGraph.GetBitmap();
        }
    }
}
