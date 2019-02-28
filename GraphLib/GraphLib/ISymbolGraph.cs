using System;
using System.Collections.Generic;
using System.Text;

namespace GraphLib
{
    interface ISymbolGraph
    {
        void AddNode(string key);
        void AddEdge(string firstVertex, string secondVertex);
        bool Contains(string key);
        int IndexOf(string key);
        string NameOf(int vertex);
        IGraph Graph { get; }
    }
}
