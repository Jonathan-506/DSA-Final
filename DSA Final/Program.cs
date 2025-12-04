

using DSA_Final;

public class Program
{
    public static void Main()
    {
        Map building = new Map();
        //FirstFloor
        building.AddEdge("Exit5", "I", 0);
        building.AddEdge("I", "H", 3);
        building.AddEdge("151", "H", 0);
        building.AddEdge("142", "H", 0);
        building.AddEdge("G", "H", 4);
        building.AddEdge("143", "G", 0);
        building.AddEdge("F", "G", 2);
        building.AddEdge("F", "E", 6);
        building.AddEdge("Exit4", "E", 2);
        building.AddEdge("E", "D", 3);
        building.AddEdge("D", "Exit3", 2);
        building.AddEdge("D", "C", 3);
        building.AddEdge("C", "Exit 2", 1);
        building.AddEdge("C", "B", 4);
        building.AddEdge("B", "A", 4);
        building.AddEdge("124", "B", 0);
        building.AddEdge("122", "B", 0);
        building.AddEdge("123", "B", 0);
        building.AddEdge("A", "Exit1", 0);

        //second Floor
        building.AddEdge("AA", "A", 8);
        building.AddEdge("AA", "BB", 6);
        building.AddEdge("223", "BB", 0);
        building.AddEdge("BB", "CC", 2);
        building.AddEdge("225", "CC", 0);
        building.AddEdge("CC", "DD", 6);
        building.AddEdge("DD", "E", 6);
        building.AddEdge("EE", "DD", 8);
        building.AddEdge("254", "EE", 0);
        building.AddEdge("243", "EE", 0);
        building.AddEdge("FF", "EE", 3);
        building.AddEdge("251", "FF", 0);
        building.AddEdge("GG", "FF", 2);
        building.AddEdge("GG", "I", 8);

        //Third Floor
        building.AddEdge("AAA", "AA", 8);
        building.AddEdge("BBB", "AAA", 6);
        building.AddEdge("323", "BBB", 0);
        building.AddEdge("324", "BBB", 0);
        building.AddEdge("CCC", "BBB", 8);
        building.AddEdge("CCC", "DD", 6);
        building.AddEdge("DDD", "CCC", 4);
        building.AddEdge("354", "DDD", 0);
        building.AddEdge("EEE", "DDD", 4);
        building.AddEdge("353", "EEE", 0);
        building.AddEdge("343", "EEE", 0);
        building.AddEdge("EEE", "FFF", 2); 
        building.AddEdge("342", "FFF", 0);
        building.AddEdge("351", "FFF", 0);
        building.AddEdge("341", "FFF", 0);
        building.AddEdge("FFF", "GGG", 3);
        building.AddEdge("GGG", "GG", 8);

        building.PrintGraph();

        Console.WriteLine(building.Dijkstra("341"));
    }

}