using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Final
{
   //used MicroSoft Copilot AI to help understand and write this code 
   // I then used the GitHub Copilot to debug and refactor the code to be more understandable for myself
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
            if (weight < 0)
            {
                weight = 0;
            }
            AddNode(firstNode);
            AddNode(secondNode);
            Graph[firstNode][secondNode] = weight;
            Graph[secondNode][firstNode] = weight;
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

        public List<string> GetPath(Dictionary<string,string> previous, string target)
        {
            var path = new List<string>();
            if (!previous.ContainsKey(target)) return path;
            string current = target;
            while (current != null)
            {
                path.Insert(0, current);
                if (!previous.TryGetValue(current, out current)) break;
            }
            return path;
        }

        public void OptimizeEvacuationPlan(Dictionary<string, int> roomStudents, List<string> exits)
        {
            
            var capacities = new Dictionary<string, int>
            {
                { "E", 200 },
                { "DD", 200 },
                { "CCC", 200 },
                { "GGG", 100 },
                { "GG", 100 },
                { "I", 100 },
                { "AAA", 100 },
                { "AA", 100 },
                { "A", 100 },
                { "Exit1", 300 },
                { "Exit2", 300 },
                { "Exit3", 300 },
                { "Exit4", 300 },
                { "Exit5", 300 }
            };


            var usage = new Dictionary<string, int>();
            foreach (var key in capacities.Keys)
            {
                usage[key] = 0;
            }

            Console.WriteLine("--- Evacuation Plan ---");

            foreach (var room in roomStudents.Keys)
            {
                int totalStudents = roomStudents[room];


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


                int splitCount = pathOptions.Count;
                int studentsPerPath = totalStudents / splitCount;

                Console.WriteLine($"Room: {room} ({totalStudents} students):");

                foreach (var option in pathOptions)
                {
                   
                    foreach (var node in option.path)
                    {
                        if (capacities.ContainsKey(node))
                        {
                            usage[node] += studentsPerPath;
                        }
                    }

                    Console.WriteLine($" -> {studentsPerPath} students via {string.Join(" -> ", option.path)} (BaseTime={option.baseTime})");
                }
            }

            
            
            Console.WriteLine("\nChoke Point Usage:");
            foreach (var choke in usage.Keys.OrderBy(k => k))
            {
                 int used = usage[choke];
                 int cap = capacities[choke];
                 double penalty = used > cap ? (double)(used - cap) / cap : 0.0;
                 Console.WriteLine($"{choke}: {used} students, Capacity={cap}, Penalty={penalty:F2}");
            }
        }       
    }
}
