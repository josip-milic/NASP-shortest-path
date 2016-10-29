using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    public class ShortestPathCalculator
    {

        public static void CalcShortestPath(WeightedGraph graph)
        {
            Dictionary<string, int> verticesDict = new Dictionary<string, int>();
            List<string> chosenPath = new List<string>();
            Dictionary<string, string> predecessorDict = new Dictionary<string, string>();
            foreach (string vertix in graph.Vertices)
            {
                if (!vertix.Equals(graph.startVertex))
                {
                    verticesDict.Add(vertix, int.MaxValue);
                }
            }
            verticesDict.Add(graph.startVertex , 0);
            predecessorDict.Add(graph.startVertex, null);

            List<string> queue = new List<string>();
            queue.AddRange(graph.Vertices);
            //queue.Remove(graph.startVertex);

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
                queue.Remove(u);

                foreach (string v in graph.adjacentVertices[u])
                {
                    if (verticesDict[u] + graph.GetWeight(u, v) < verticesDict[v])
                    {
                        verticesDict[v] = verticesDict[u] + graph.GetWeight(u, v);
                        //verticesDict[u] = verticesDict[v]
                        predecessorDict[v] = u;
                    }
                    chosenPath.Add(u);
                }
            }

            List<string> path = new List<string>();
            foreach (string v in graph.Vertices)
            {
                if (v.Equals(graph.startVertex)) continue;
                path.Clear();
                if (predecessorDict[v] == null)
                {
                    Console.WriteLine("Do mjesta {0} se ne može doći iz mjesta {1}!", v, graph.startVertex);
                    continue;
                }

                string v2 = v;
                while (predecessorDict[v2] != null)
                {
                    path.Add(predecessorDict[v2]);
                    v2 = predecessorDict[v2];
                }

                string line = "{0} [{1}]: ";
                int wSum = 0;
                //Console.Write("{0} [{1}]: ", v);
                path.Reverse();
                for (int i = 0; i < path.Count; i++)
                {
                    string v3 = path[i];
                    int w = i != path.Count - 1 ? graph.GetWeight(v3, path[i + 1]) : graph.GetWeight(v3, v);
                    line += string.Format("{0} --[{1}]--> ", v3, w);
                    wSum += w;
                    //Console.Write("{0} --[{1}]-->", v3, w);
                }

                line += v;
                //Console.WriteLine(v);
                Console.WriteLine(line, v, wSum);
            }

        }
        
    }
}
