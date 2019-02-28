using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLib
{
    public class BasicGraph : IGraph
    {
        public BasicGraph(int Vertices)
        {
            adjList = new List<List<int>>();
        }

        public BasicGraph()
        {
            adjList = new List<List<int>>();
        }
        public void AddEdge(int i, int j)
        {
            while (i >= NVertices)
            {
                adjList.Add(new List<int>(i));
            }
            adjList[i].Add(j);

            while (j >= NVertices)
            {
                adjList.Add(new List<int>(j));
            }
            adjList[j].Add(i);

            NEdges++;
        }

        public IEnumerable<int> GetAdjacentVertices(int vertexId)
        {
            return adjList[vertexId];
        }

        

        public List<List<int>> adjList;

        public int NVertices
        {
            get
            {
                return adjList.Count(); 
            }
        }

        public int NEdges { get; set; }
    }

}
