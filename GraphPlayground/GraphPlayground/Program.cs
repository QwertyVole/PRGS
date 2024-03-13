using System;

namespace GraphPlayground
{
    internal class Program
    {
        public static void DFS(Graph graph, Node startNode, Node targetNode = null)
        {
            Node currentNode = startNode;
            
            while (true)
            {
                Node NeighborToVisit = null;
                bool haveNeighborToVisit = false;
                Console.WriteLine("Starting from" + startNode.index);
                foreach(Node neighbor in currentNode.neighbors)
                {
                    if (!neighbor.visited)
                    {
                        NeighborToVisit = neighbor;
                    }
                }
                if(NeighborToVisit == null)
                {
                    if(currentNode == startNode)
                    {
                        Console.WriteLine("Its the end of the line");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Jsem ve slepé uličce, vracím se do uzlu" + currentNode.cameFrom.index);
                        NeighborToVisit = currentNode.cameFrom;
                        break; 
                    }
                    
                }

            }

        }

        public static void BFS(Graph graph, Node startNode, Node targetNode = null) 
        {
            
        }

        static void Main(string[] args)
        {
            //Create and print the graph
            Graph graph = new Graph();
            graph.PrintGraph();
            graph.PrintGraphForVisualization();

            //Call both algorithms with a random starting node
            Random rng = new Random();
            DFS(graph, graph.nodes[rng.Next(0, graph.nodes.Count)]);
            BFS(graph, graph.nodes[rng.Next(0, graph.nodes.Count)]);

            Console.ReadKey();
        }
    }
}
