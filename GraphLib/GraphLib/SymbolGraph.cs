using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GraphLib
{
    public class SymbolGraph : ISymbolGraph, IGraph
    {
        public SymbolGraph()
        {

        }
        public SymbolGraph(string filename, char delimiter)
        {
            Graph = new BasicGraph();
            StreamReader reader = new StreamReader(filename);
            string nextLine;
            while (!reader.EndOfStream)
            {
                nextLine = reader.ReadLine();
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

        public IGraph Graph { get; }

        Dictionary<string, int> KeyToVertexId = new Dictionary<string, int>();
        Dictionary<int, string> VertexIdToKey = new Dictionary<int, string>();

        public int NVertices
        {
            get
            {
                return Graph.NVertices;
            }
        }

        public int NEdges
        {
            get
            {
                return Graph.NEdges;
            }
        }

        char[] Delimiter = new char[1];

        public void AddNode(string key)
        {
            throw new NotImplementedException();
        }

        public void AddEdge(string firstVertex, string secondVertex)
        {
            Graph.AddEdge(firstVertex, secondVertex);
        }

        public bool Contains(string key)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(string key)
        {
            throw new NotImplementedException();
        }

        public string NameOf(int vertex)
        {
            throw new NotImplementedException();
        }

        public void AddEdge(int firstVertex, int secondVertex)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<int> GetAdjacentVertices(int vertexId)
        {
            throw new NotImplementedException();
        }
    }
}

