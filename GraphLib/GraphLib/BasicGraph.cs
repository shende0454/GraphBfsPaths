using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLib
{

    public class BasicGraph : IGraph
    {
       public List<List<int>> _adjacencyList;
       
        public BasicGraph()
        {

            NEdges = 0;
            NVertices = 0;
            _adjacencyList = new List<List<int>>();
            foreach (List<int> i in _adjacencyList)
            {
                i.Clear();
            }
        }

        public int NVertices { get; set; }
        public int NEdges { get; set; }

        public void MakeVertex(int id)
        {
            while (_adjacencyList.Count <= id)
            {
                _adjacencyList.Add(new List<int>());
            }
            NVertices++;
        }
        public void AddEdge(int firstVertex, int secondVertex)
        {
            MakeVertex(firstVertex);
            MakeVertex(secondVertex);
            _adjacencyList[firstVertex].Add(secondVertex);
            
        }

        public IEnumerable<int> GetAdjacentVertices(int vertexId)
        {
                     return _adjacencyList[vertexId];
        }
    }

}
