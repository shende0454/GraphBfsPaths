using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLib
{
    public class BreadthFirstPaths
    {
        private bool[] marked; // Is a shortest path to this vertex known?
        private int[] edgeTo; // last vertex on known path to this vertex
        private int s; // source
        public BreadthFirstPaths(IGraph graph, int source)
        {
            marked = new bool[graph.NVertices];
            edgeTo = new int[graph.NVertices];
            this.s = source;
            bfs(graph, s);
        }
        public void bfs(IGraph graph, int s)
        {

            {
                Queue<int> queue = new Queue<int>();
                marked[s] = true; // Mark the source
                queue.Enqueue(s); // and put it on the queue.
                while (queue.Count() != 0)
                {
                    int v = queue.Dequeue(); // Remove next vertex from the queue.
                    foreach (int w in graph.GetAdjacentVertices(v))
                        if (!marked[w]) // For every unmarked adjacent vertex,
                        {
                            edgeTo[w] = v; // save last edge on a shortest path,
                            marked[w] = true; // mark it because path is known,
                            queue.Enqueue(w); // and add it to the queue.
                        }
                }
            }
        }
        private void validateVertex(int v)
        {
            int V = marked.Length;
            if (v < 0 || v >= V)
                throw new Exception("vertex " + v + " is not between 0 and " + (V - 1));
        }
        public bool hasPathTo(int v)
        { 
            return marked[v]; 
        }
        public IEnumerable<int> PathTo(int v)
        {
            if (!hasPathTo(v)) return null;
            Stack<int> path = new Stack<int>();
            for (int x = v; x != s; x = edgeTo[x])
                path.Push(x);
            path.Push(s);
            return path;
        }
    }
}
