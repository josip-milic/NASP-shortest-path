using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    public class WeightedGraph
    {
        private Dictionary<string, int> edges = new Dictionary<string, int>();
        public Dictionary<string, List<string>> adjacentVertices = new Dictionary<string, List<string>>();
        private List<string> vertices = new List<string>();

        public List<string> Vertices
        {
            get { return vertices; }
        }

        public WeightedGraph(string[] graphFileLines)
        {
            int current = 1;
            while (current < graphFileLines.Length)
            {
                string line = graphFileLines[current++];
                string[] lineSplit = line.Split(';');
                string vertex1 = lineSplit[0];
                string vertex2 = lineSplit[1];
                int weight = int.Parse(lineSplit[2]);

                if (!vertices.Contains(vertex1))
                {
                    vertices.Add(vertex1);
                }
                if (!vertices.Contains(vertex2))
                {
                    vertices.Add(vertex2);
                }

                edges.Add(vertex1 + ';' + vertex2, weight);
                edges.Add(vertex2 + ';' + vertex1, weight);

                if (!adjacentVertices.ContainsKey(vertex1))
                {
                    adjacentVertices.Add(vertex1, new List<string>() { vertex2 });
                }
                else
                {
                    if (!adjacentVertices[vertex1].Contains(vertex2))
                    {
                        adjacentVertices[vertex1].Add(vertex2);
                    }
                }

                if (!adjacentVertices.ContainsKey(vertex2))
                {
                    adjacentVertices.Add(vertex2, new List<string>() { vertex1 });
                }
                else
                {
                    if (!adjacentVertices[vertex2].Contains(vertex1))
                    {
                        adjacentVertices[vertex2].Add(vertex1);
                    }
                }
            }
            vertices.Sort();
        }

        public int IndexOfVertice(string verticeName)
        {
            return vertices.IndexOf(verticeName);
        }

        public string GetVerticeName(int verticeIndex)
        {
            return vertices[verticeIndex];
        }

        public Boolean Connected(string vertix1, string vertix2)
        {
            return (edges.ContainsKey(vertix1 + ';' + vertix2));
        }

        public int GetWeight(string vertix1, string vertix2)
        {

            return edges[vertix1 + ';' + vertix2];
        }
    }
}
