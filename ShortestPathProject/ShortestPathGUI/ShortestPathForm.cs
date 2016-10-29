using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortestPath
{
    public partial class ShortestPathForm : Form
    {
        private WeightedGraph graph;
        private string startVertex = null;
        private string endVertex = null;
        private ShortestPathCalculator pathCalculator = new ShortestPathCalculator();

        public ShortestPathForm()
        {
            InitializeComponent();
        }

        private void ShortestPathForm_Load(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Josip\Documents\FAKS\NASP\LAB3\gradovi.txt");
            graph = new WeightedGraph(lines);
            string[] vertices = graph.Vertices.ToArray<string>();
            cbStart.Items.AddRange(vertices);
            cbEnd.Items.AddRange(vertices);
        }

        private void showPath()
        {
            pathCalculator.CalcShortestPath(graph, startVertex, endVertex);
            Boolean noPath = false;
            int wSum = 0;
            lbPath.Items.Clear();
            for (int i = 0; i < pathCalculator.Path.Count; i++)
            {
                string vertex = pathCalculator.Path[i];
                if (vertex == null)
                {
                    noPath = true;
                    break;
                }
                lbPath.Items.Add(vertex);
                int w = pathCalculator.PathWeights[i];
                lbPath.Items.Add("+" + w);
                wSum += w;
            }
            if (noPath)
            {
                lbPath.Items.Add("Do ovog mjesta ne postoji put!");
                lblWSum.Visible = true;
                tbWSum.Visible = true;
                tbWSum.Text = "? km";
            }
            else
            {
                lbPath.Items.Add(endVertex);
                lblWSum.Visible = true;
                tbWSum.Visible = true;
                tbWSum.Text = wSum + " km";
            }
        }

        private void cbStart_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox comboBox = (ComboBox)sender;
            startVertex = cbStart.Items[comboBox.SelectedIndex].ToString();

            if (endVertex != null) showPath();         
        }

        private void cbEnd_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox comboBox = (ComboBox)sender;
            endVertex = cbEnd.Items[comboBox.SelectedIndex].ToString();

            if (startVertex != null) showPath();
        }

    }
}
