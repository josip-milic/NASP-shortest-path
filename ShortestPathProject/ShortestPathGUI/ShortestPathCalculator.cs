using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    public class ShortestPathCalculator
    {
        private Dictionary<string, int> verticesDict = new Dictionary<string, int>();
        private Dictionary<string, string> predecessorDict = new Dictionary<string, string>();
        private List<string> path = new List<string>();
        private List<int> pathWeights = new List<int>();



        public void CalcShortestPath(WeightedGraph graph, string startVertex, string endVertex)
        {
            verticesDict.Clear();
            predecessorDict.Clear();
            foreach (string vertix in graph.Vertices)
            {
                if (!vertix.Equals(startVertex))
                {
                    verticesDict.Add(vertix, int.MaxValue);
                }
            }
            verticesDict.Add(startVertex, 0);
            predecessorDict.Add(startVertex, null);

            List<string> queue = new List<string>();
            queue.AddRange(graph.Vertices);

            while (queue.Count != 0)
            {
                string u = null;
                int minimum = int.MaxValue;
                foreach (string v in queue)
                {
                    if (verticesDict[v] < minimum)
                    {
                        minimum = verticesDict[v];
                        u = v;
                    }
                }
                if (u != null)
                {
                    queue.Remove(u);

                    foreach (string v in graph.adjacentVertices[u])
                    {
                        if ((graph.Connected(u, v)) && (verticesDict[u] + graph.GetWeight(u, v) < verticesDict[v]))
                        {
                            verticesDict[v] = verticesDict[u] + graph.GetWeight(u, v);
                            predecessorDict[v] = u;
                        }
                    }
                }
                else break;
            }


            path.Clear();
            pathWeights.Clear();

            string v2 = endVertex;
            if (predecessorDict.ContainsKey(v2))
            {
                while (predecessorDict[v2] != null)
                {
                    path.Add(predecessorDict[v2]);
                    v2 = predecessorDict[v2];
                }
                path.Reverse();
                for (int i = 0; i < path.Count; i++)
                {
                    string v3 = path[i];
                    int w = i != path.Count - 1 ? graph.GetWeight(v3, path[i + 1]) : graph.GetWeight(v3, endVertex);
                    pathWeights.Add(w);
                }
            }
            else
            {
                path.Add(null);
                PathWeights.Add(int.MaxValue);
            }



        }

        public List<string> Path
        {
            get
            {
                return path;
            }

            set
            {
                path = value;
            }
        }

        public List<int> PathWeights
        {
            get
            {
                return pathWeights;
            }

            set
            {
                pathWeights = value;
            }
        }


        public void GetAllPaths(WeightedGraph graph, string startVertex)
        {
            List<List<string>> paths = new List<List<string>>();
            List<List<int>> pathWeights = new List<List<int>>();

            List<string> path = new List<string>();
            List<int> pathWeight = new List<int>();
            foreach (string v in graph.Vertices)
            {
                if (v.Equals(startVertex)) continue;
                path.Clear();
                if (predecessorDict[v] == null)
                {
                    continue;
                }

                string v2 = v;
                while (predecessorDict[v2] != null)
                {
                    path.Add(predecessorDict[v2]);
                    v2 = predecessorDict[v2];
                }

                path.Reverse();
                for (int i = 0; i < path.Count; i++)
                {
                    string v3 = path[i];
                    int w = i != path.Count - 1 ? graph.GetWeight(v3, path[i + 1]) : graph.GetWeight(v3, v);
                    pathWeight.Add(w);
                }

                paths.Add(path);
                pathWeights.Add(pathWeight);
            }
        }
        
    }
}
