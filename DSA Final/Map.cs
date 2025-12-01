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

        public void AddVertex(string vertex)
        {
            if(!Graph.ContainsKey(vertex))
            {
                Graph[vertex] = new Dictionary<string, int>();
            }
        }

        public void AddEdge(string firstVertex, string secondVertex, int weight)
        {
            if(weight < 0)
            {
                throw new ArgumentException("Cannot be below 0");
            }

            AddVertex(firstVertex);
            AddVertex(secondVertex);
            Graph[firstVertex][secondVertex] = weight;
        }

        public void PrintGraph()
        {
            foreach(var vertex in Graph)
            {
                Console.Write($"{vertex.Key} goes to: ");
                foreach(var value in vertex.Value)
                {
                    Console.Write($"{value.Key} {value.Value}");
                }

                Console.WriteLine();
            }
        }
    }
}
