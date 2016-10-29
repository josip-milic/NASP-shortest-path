using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] graphFileLines = System.IO.File.ReadAllLines(@"C:\Users\Josip\Documents\FAKS\NASP\LAB3\graph3.txt");
            WeightedGraph graph = new WeightedGraph(graphFileLines);

            ShortestPathCalculator.CalcShortestPath(graph);
        }
    }
}
