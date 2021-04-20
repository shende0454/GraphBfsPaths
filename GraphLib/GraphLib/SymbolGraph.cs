using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GraphLib
{
    public class SymbolGraph : ISymbolGraph, IGraph
    {
       public IDictionary<string, int> KeyToVertexId;
       public IDictionary<int, string> VertexIdToKey;
       public List<List<int>> _adjacencyList;
      
        public SymbolGraph()
        {
            Graph = new BasicGraph();
            KeyToVertexId = new Dictionary<string, int>();
            VertexIdToKey = new Dictionary<int, string>();
            _adjacencyList = new List<List<int>>();
            foreach (List<int> i in _adjacencyList)
            {
                i.Clear();
            }

        }
        public SymbolGraph(string filename, char delimiter)
        {
            Graph = new BasicGraph();
            KeyToVertexId = new Dictionary<string, int>();
            VertexIdToKey = new Dictionary<int, string>();
            _adjacencyList = new List<List<int>>();
            StreamReader reader = new StreamReader(filename);
            string nextLine;
            while (!reader.EndOfStream)
            {
                nextLine = reader.ReadLine();
                char[] Delimiter = new char[1];
                Delimiter[0] = delimiter;
                string[] keys =
                    nextLine.Split(Delimiter, StringSplitOptions.RemoveEmptyEntries);

                string source = keys[0];
                for (int i = 1; i < keys.Length; i++)
                {
                    AddEdge(source, keys[i]);
                }
            }
        }

        public IGraph Graph { get; set; }

        public int NVertices { get; set; }

        public int NEdges { get; set; }
        
        public void MakeVertex(int id)
        {
            
                while (_adjacencyList.Count <= id)
                {
                    _adjacencyList.Add(new List<int>());
                }
            
          
        }
        public void AddEdge(string firstVertex, string secondVertex)
        {
           
            
           
            if (KeyToVertexId.ContainsKey(firstVertex) == false)
            {
                AddNode(firstVertex);
            }
          

            if (KeyToVertexId.ContainsKey(secondVertex) == false)
            {
                AddNode(secondVertex);
            }
            int firstId = KeyToVertexId[firstVertex];
            int secondId = KeyToVertexId[secondVertex];
            MakeVertex(firstId);
            MakeVertex(secondId);
            if (_adjacencyList[firstId].Contains(secondId) == false)
            {
                _adjacencyList[firstId].Add(secondId);
            }
            if (_adjacencyList[secondId].Contains(firstId) == false)
            {
                _adjacencyList[secondId].Add(firstId);
            }
            NEdges++;
        }
        public string this[int index]
        {
            get 
            {
                string retVal = " ";
                if (VertexIdToKey.ContainsKey(index))
                {
                    foreach (KeyValuePair<int, string> theKeys in VertexIdToKey)
                    {
                        if (theKeys.Key == index)
                        {
                            retVal = theKeys.Value;
                        }
                    }
                }
                return retVal;
            }
        }
        public int this[string key]
        {
            get
            {
                int intRetVal = 0;
                if (KeyToVertexId.ContainsKey(key))
                {
                    foreach (KeyValuePair<string, int> theKeys in KeyToVertexId)
                    {
                        if (theKeys.Key.Equals(key))
                        {
                            intRetVal = theKeys.Value;
                        }
                    }
                }
                
                return intRetVal;
            }
        }
       

        public void AddEdge(int firstVertex, int secondVertex)
        {
            if (VertexIdToKey.ContainsKey(firstVertex) == false)
            {
                AddNode(firstVertex);
            }


            if (VertexIdToKey.ContainsKey(secondVertex) == false)
            {
                AddNode(secondVertex.ToString());
            }
            int firstId = KeyToVertexId[firstVertex.ToString()];
            int secondId = KeyToVertexId[secondVertex.ToString()];
            MakeVertex(firstId);
            MakeVertex(secondId);
            if (_adjacencyList[firstId].Contains(secondId) == false)
            {
                _adjacencyList[firstId].Add(secondId);
            }
            if (_adjacencyList[secondId].Contains(firstId) == false)
            {
                _adjacencyList[secondId].Add(firstId);
            }
            NEdges++;
        }

        public void AddNode(string key)
        {
            int id = KeyToVertexId.Count;
            KeyToVertexId.Add(key, id);
            VertexIdToKey.Add(id, key);

        }
        public void AddNode(int key)
        {
            int id = VertexIdToKey.Count;
            KeyToVertexId.Add(key, id);
            VertexIdToKey.Add(id, key);

        }
        public bool Contains(string key)
        {
            bool isContained = false;
            for (int i = 0; i < _adjacencyList.Count; i++)
            {
                if (_adjacencyList[i].Contains(this[key]))
                {
                    isContained = true;
                }
            }
            return isContained;
        }

        public IEnumerable<int> GetAdjacentVertices(int vertexId)
        {
            return _adjacencyList[vertexId];
        }

        public int IndexOf(string key)
        {
            int retVal = 0;
            for (int i = 0; i < _adjacencyList.Count; i++)
            {
                if (_adjacencyList[i].Contains(this[key]))
                {
                    retVal = _adjacencyList[i].IndexOf(this[key]);
                }
            }
            return retVal;
        }

        public string NameOf(int vertex)
        {
            string name = " ";
            for (int i = 0; i < _adjacencyList.Count; i++)
            {
                for (int j = 0; j < _adjacencyList[i].Count; j++)
                {
                    if (vertex == _adjacencyList[i][j])
                    {
                        name = this[_adjacencyList[i][j]];
                    }
                }
            }
            return name;
        }
    }
}

