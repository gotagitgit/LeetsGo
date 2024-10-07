using DataStruct.Matrices;

namespace MainApp.Matrix;

internal class AdjacencyMatrix
{
    public static void Run()
    {
        var graph = new Graph(5);

        graph.Nodes.Add(new Node('A'));
        graph.Nodes.Add(new Node('B'));
        graph.Nodes.Add(new Node('C'));
        graph.Nodes.Add(new Node('D'));
        graph.Nodes.Add(new Node('E'));

        graph.AddEdge(0, 1);
        graph.AddEdge(1, 2);
        graph.AddEdge(2, 3);
        graph.AddEdge(2, 4);
        graph.AddEdge(4, 0);
        graph.AddEdge(4, 2);

        DisplayGraph(graph);
    }

    public static void DisplayGraph(Graph graph)
    {
        var rowLength = graph.Matrix.GetLength(0);
        var columnLength = graph.Matrix.GetLength(1);

        for (int row = 0; row < rowLength; row++)
        {
            for (int column = 0; column < columnLength; column++)
            {
                Console.Write($"{graph.Matrix[row, column]} ");
            }

            Console.WriteLine();
        }

    }
}
