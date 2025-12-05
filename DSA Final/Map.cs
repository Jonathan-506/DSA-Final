using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Final
{
   //used Ai to help understand and write this code
   //because I missed the graph section of class due to sickness
    internal class Map
    {

        public Dictionary<string, Dictionary<string,int>> Graph { get; set; }

        public Map()
        {
            Graph = new Dictionary<string, Dictionary<string, int>>();
        }

        public void AddNode(string node)
        {
            if(!Graph.ContainsKey(node))
            {
                Graph[node] = new Dictionary<string, int>();
            }
        }

        public void AddEdge(string firstNode, string secondNode, int weight)
        {
            if(weight < 0)
            {
                weight = 0;
            }

            AddNode(firstNode);
            AddNode(secondNode);
            Graph[firstNode][secondNode] = weight;
        }

        public void PrintGraph()
        {
            foreach(var node in Graph)
            {
                Console.Write($"{node.Key} goes to: ");
                foreach(var value in node.Value)
                {
                    Console.Write($"{value.Key} with a distance of {value.Value}, ");
                }

                Console.WriteLine();
            }
        }

        public decimal Dijkstra(string start, Penalty penalty)
        {
            decimal penaltySum = 0;
            string exit1 = "Exit1";
            string exit2 = "Exit2";
            string exit3 = "Exit3";
            string exit4 = "Exit4";
            string exit5 = "Exit5";
            decimal distance = 0;
            // Step 1: Create a dictionary to store shortest distances
            var distances = new Dictionary<string, int>();

            // Step 2: Initialize all distances to "infinity" (here, int.MaxValue)
            foreach (var node in Graph.Keys)
            {
                distances[node] = int.MaxValue;
            }

            // Distance to the start node is always 0
            distances[start] = 0;

            // Step 3: Keep track of visited nodes
            var visited = new HashSet<string>();

            // Step 4: Loop until all nodes are visited
            while (visited.Count < Graph.Count)
            {
                // Find the unvisited node with the smallest distance
                string currentNode = null;
                int smallestDistance = int.MaxValue;

                foreach (var node in Graph.Keys)
                {
                    if (!visited.Contains(node) && distances[node] < smallestDistance)
                    {
                        penalty.ComputePenalty(node);
                        smallestDistance = distances[node];
                        currentNode = node;
                    }
                }

                // If we can't find a reachable node, break
                if (currentNode == null)
                {
                    break;
                }

                // Mark this node as visited
                visited.Add(currentNode);

                // Step 5: Update distances to neighbors
                foreach (var neighbor in Graph[currentNode])
                {
                    int newDistance = distances[currentNode] + neighbor.Value;

                    // If new path is shorter, update it
                    if (newDistance < distances[neighbor.Key])
                    {
                        distances[neighbor.Key] = newDistance;
                    }
                }
            }

            // Return the dictionary of shortest distances
            //return distances;
            
                if (distances.ContainsKey(exit1))
                {
                    distance = distances[exit1];
                }
                if (distances.ContainsKey(exit2) && distance > distances[exit2])
                {
                    distance = distances[exit2];
                }
                if (distances.ContainsKey(exit3) && distance > distances[exit3])
                {
                    distance = distances[exit3];
                }
                if (distances.ContainsKey(exit4) && distance > distances[exit4])
                {
                    distance = distances[exit4];
                }
                if (distances.ContainsKey(exit5) && distance > distances[exit5])
                {
                    distance = distances[exit5];
                }

            penaltySum = penalty.SumOfPenalties(start);
            
            return distance * (1 + penaltySum);
        }
    }
}
