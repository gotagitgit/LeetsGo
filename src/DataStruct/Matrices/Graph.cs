namespace DataStruct.Matrices;

public class Graph(int size)
{
    private readonly int[,] _matrix = new int[size, size];

    public int[,] Matrix => _matrix;

    public List<Node> Nodes { get; } = [];

    public void AddEdge(int source, int destination)
    {
        _matrix[source, destination] = 1;
    }

    public bool CheckEdge(int source, int destination) 
    {
        return _matrix[source, destination] == 1;
    }
}
