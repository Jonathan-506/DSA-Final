using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Final
{
   //used Ai to help understand and write this code
   //This was my first time using ai to help with assignments 
   //So this was a really good learing experience for me
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


        public (Dictionary<string, int> distances, Dictionary<string, string> previous) Dijkstra(string start)
        {
            var distances = new Dictionary<string, int>();
            var previous = new Dictionary<string, string>();

            foreach (var node in Graph.Keys)
            {
                distances[node] = int.MaxValue;
                previous[node] = null;
            }

            distances[start] = 0;
            var visited = new HashSet<string>();

            while (visited.Count < Graph.Count)
            {
                string currentNode = null;
                int smallestDistance = int.MaxValue;

                foreach (var node in Graph.Keys)
                {
                    if (!visited.Contains(node) && distances[node] < smallestDistance)
                    {
                        smallestDistance = distances[node];
                        currentNode = node;
                    }
                }

                if (currentNode == null) break;

                visited.Add(currentNode);

                foreach (var neighbor in Graph[currentNode])
                {
                    int newDistance = distances[currentNode] + neighbor.Value;
                    if (newDistance < distances[neighbor.Key])
                    {
                        distances[neighbor.Key] = newDistance;
                        previous[neighbor.Key] = currentNode;
                    }
                }
            }

            return (distances, previous);
        }

        // Reconstruct path from start to target
        public List<string> GetPath(Dictionary<string, string> previous, string target)
        {
            var path = new List<string>();
            string current = target;

            while (current != null)
            {
                path.Insert(0, current);
                current = previous[current];
            }

            return path;
        }

        public void OptimizeEvacuation(Dictionary<string, int> roomStudents, List<string> exits)
        {
            // Capacities
            var capacities = new Dictionary<string, int>
            {
                { "CenterStair", 200 },
                { "SideStair", 100 },
                { "Exit1", 300 },
                { "Exit2", 300 }
            };

            // Usage counts
            var usage = capacities.Keys.ToDictionary(k => k, k => 0);

            Console.WriteLine("\n--- Building-Wide Optimization ---");

            foreach (var room in roomStudents.Keys)
            {
                int totalStudents = roomStudents[room];

                // Compute shortest paths to each exit
                var (distances, previous) = Dijkstra(room);

                var pathOptions = new List<(string exit, List<string> path, int baseTime)>();

                foreach (var exit in exits)
                {
                    var path = GetPath(previous, exit);
                    if (path.Count > 1 && distances[exit] < int.MaxValue)
                    {
                        pathOptions.Add((exit, path, distances[exit]));
                    }
                }

                // Simple heuristic: split evenly across available exits
                int splitCount = pathOptions.Count;
                int studentsPerPath = totalStudents / splitCount;

                Console.WriteLine($"\nRoom {room} ({totalStudents} students):");

                foreach (var option in pathOptions)
                {
                    // Add usage to choke points
                    foreach (var node in option.path)
                    {
                        if (capacities.ContainsKey(node))
                        {
                            usage[node] += studentsPerPath;
                        }
                    }

                    Console.WriteLine($"  -> {studentsPerPath} students via {string.Join(" -> ", option.path)} (BaseTime={option.baseTime})");
                }
            }

            // Compute penalties
            var penalties = new Dictionary<string, double>();
            foreach (var choke in usage.Keys)
            {
                if (usage[choke] <= capacities[choke])
                    penalties[choke] = 0;
                else
                    penalties[choke] = (double)(usage[choke] - capacities[choke]) / capacities[choke];
            }

            // Report choke point usage
            Console.WriteLine("\nChoke Point Usage:");
            foreach (var choke in usage.Keys)
            {
                Console.WriteLine($"{choke}: {usage[choke]} students, Capacity={capacities[choke]}, Penalty={penalties[choke]:F2}");
            }
        }       
    }
}
