using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraphLib;
using System.Collections.Generic;

namespace GraphTests
{
    [TestClass]
    public class GraphTests
    {
        //    [TestMethod]
        //    public void createGraph()
        //    {
        //        BasicGraph myGraph = new BasicGraph(2);
        //        myGraph.AddEdge(0, 1);
        //        foreach (var vertex in myGraph.GetAdjacentVertices(1))
        //        {
        //            Assert.AreEqual(0, vertex);
        //        }
        //    }

        //    [TestMethod]
        //    public void createEmptyGraph()
        //    {
        //        BasicGraph myGraph = new BasicGraph();
        //        myGraph.AddEdge(0, 1);
        //        foreach (var vertex in myGraph.GetAdjacentVertices(1))
        //        {
        //            Assert.AreEqual(0, vertex);
        //        }
        //    }

        //    [TestMethod]
        //    public void createSymbolGraph()
        //    {
        //        SymbolGraph myGraph = new SymbolGraph();
        //        myGraph.AddEdge("a", "b");
        //        foreach (var vertex in
        //            myGraph.GetAdjacentVertices(myGraph.KeyToVertexId["a"]))
        //        {
        //            Assert.AreEqual("b", myGraph.VertexIdToKey[vertex]);
        //        }
        //    }

        //    Move oneEntry.txt to the bin/Debug of the test project.
        //    [TestMethod]
        //    public void readOneEntrySymbolGraph()
        //    {
        //        SymbolGraph myGraph = new SymbolGraph("oneEntry.txt", '/');
        //        int counter = 0;
        //        foreach (int vertex in
        //            myGraph.GetAdjacentVertices(myGraph.KeyToVertexId["'Breaker' Morant (1980)"]))
        //        {
        //            if (counter == 0)
        //            {
        //                Assert.AreEqual("Brown, Bryan (I)",
        //                    myGraph.VertexIdToKey[vertex]);
        //            }
        //            ++counter;
        //        }
        //        Assert.AreEqual(42, counter);
        //    }

        //    Move tenMovies.txt to the bin/Debug of the test project.
        //    [TestMethod]
        //    public void readTenEntrySymbolGraph()
        //    {
        //        SymbolGraph myGraph = new SymbolGraph("tenMovies.txt", '/');
        //        int counter = 0;
        //        foreach (int vertex in
        //            myGraph.GetAdjacentVertices(myGraph.KeyToVertexId["10 Things I Hate About You (1999)"]))
        //        {
        //            if (counter == 0)
        //            {
        //                Assert.AreEqual("Jackson, Greg (II)",
        //                    myGraph.VertexIdToKey[vertex]);
        //            }
        //            ++counter;
        //        }
        //        Assert.AreEqual(50, counter);
        //    }

        //    [TestMethod]
        //    public void testBFS()
        //    {
        //        BasicGraph graph = new BasicGraph();
        //        graph.AddEdge(0, 5);
        //        graph.AddEdge(4, 3);
        //        graph.AddEdge(0, 1);
        //        graph.AddEdge(9, 12);
        //        graph.AddEdge(6, 4);
        //        graph.AddEdge(5, 4);
        //        graph.AddEdge(0, 2);
        //        graph.AddEdge(11, 12);
        //        graph.AddEdge(9, 10);
        //        graph.AddEdge(0, 6);
        //        graph.AddEdge(7, 8);
        //        graph.AddEdge(9, 11);
        //        graph.AddEdge(5, 3);

        //        List<int> result = new List<int>();
        //        result.Add(0);
        //        result.Add(1);
        //        BreadthFirstPaths bfPaths = new BreadthFirstPaths(graph, 0);
        //        int i = 0;
        //        foreach (int inPath in bfPaths.PathTo(1))
        //        {
        //            Assert.AreEqual(result[i++], inPath);
        //        }

        //        result.Clear();
        //        result.Add(0);
        //        result.Add(5);
        //        result.Add(4);
        //        BreadthFirstPaths secondTry = new BreadthFirstPaths(graph, 0);
        //        i = 0;
        //        foreach (int inPath in secondTry.PathTo(4))
        //        {
        //            Assert.AreEqual(result[i++], inPath);
        //        }
        //    }

    // movies.txt is available here: https://algs4.cs.princeton.edu/41graph/movies.txt
    //    [TestMethod];
    //    public void readwholeMovieFile()
    //    {
    //        SymbolGraph myGraph = new SymbolGraph("movies.txt", '/');
    //        int counter = 0;
    //        foreach (int vertex in
    //            myGraph.GetAdjacentVertices(myGraph.KeyToVertexId["'Breaker' Morant (1980)"]))
    //        {
    //            if (counter == 0)
    //            {
    //                Assert.AreEqual("Brown, Bryan (I)",
    //                    myGraph.VertexIdToKey[vertex]);
    //            }
    //            ++counter;
    //        }
    //        Assert.AreEqual(42, counter);
    //    }

    //    [TestMethod]
    //    public void findMoviePath()
    //    {
    //        SymbolGraph myGraph = new SymbolGraph("movies.txt", '/');
    //        int sourceVertex = myGraph.KeyToVertexId["Animal House (1978)"];
    //        BreadthFirstPaths bfPaths = new BreadthFirstPaths(myGraph, sourceVertex);
    //        int i = 0;
    //        List<string> result = new List<string>();
    //        result.Add("Animal House (1978)");
    //        result.Add("Vernon, John (I)");
    //        result.Add("Topaz (1969)");
    //        result.Add("Charles, Lewis");
    //        result.Add("To Catch a Thief (1955)");
    //        int destination = myGraph.KeyToVertexId["To Catch a Thief (1955)"];
    //        foreach (int inPath in bfPaths.PathTo(destination))
    //        {
    //            Assert.AreEqual(result[i++], myGraph.VertexIdToKey[inPath]);
    //        }
    //    }
    }
}
