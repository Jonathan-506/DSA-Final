

using DSA_Final;

public class Program
{
    public void Main()
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
        building.AddEdge("E", " Exit4", 2);
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


        building.PrintGraph();
    }

}