using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLib
{
    public class BreadthFirstPaths
    {
        private bool[] isMarked; //shortest path 
        private int[] edgeToVertex; // last vertex to vertex
        private int source; // source
        public BreadthFirstPaths(IGraph graph, int source)
        {
            isMarked = new bool[graph.NVertices];
            edgeToVertex = new int[graph.NVertices];
            this.source = source;
            bfs(graph, source);
        }
        public void bfs(IGraph graph, int source)
        {
                Queue<int> q = new Queue<int>();
                isMarked[source] = true; // Mark the source vertex so it will be known
                q.Enqueue(source); // add to queue
                while (q.Count() != 0)
                {
                    int v = q.Dequeue(); //take out the next vertex out of queue
                    foreach (int w in graph.GetAdjacentVertices(v)) //look through adjaccent vertices
                        if (!isMarked[w]) // For all the uunmarked adjacen vertices
                        {
                            edgeToVertex[w] = v; // keep track of edge
                            isMarked[w] = true; // mark the vertex
                            q.Enqueue(w); // add to q
                        }
                }   
        }

        private void validateVertex(int vertex)
        {
            int theVertex = isMarked.Length;
            if (vertex < 0 || vertex >= theVertex)
            {
                throw new Exception("vertex " + vertex + " is not between 0 and " + (theVertex - 1));
            }
        }
        public bool hasPathTo(int vertex)
        { 
            return isMarked[vertex]; 
        }
        public IEnumerable<int> PathTo(int vertex)
        {
            if (!hasPathTo(vertex))
            {
                return null;
            }
            Stack<int> pathTo = new Stack<int>();
            for (int x = vertex; x != source; x = edgeToVertex[x])
            {
                pathTo.Push(x);
            }
            pathTo.Push(source);
            return pathTo;
        }
    }
}
