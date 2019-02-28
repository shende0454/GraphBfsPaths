using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GraphLib
{
    public class SymbolGraph : ISymbolGraph, IGraph
    {
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
        char[] Delimiter = new char[1];
    }
}

