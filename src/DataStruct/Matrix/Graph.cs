using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct.Matrix;
internal class Graph
{
    private readonly int[,] _matrix;

    public Graph(int size)
    {
        _matrix = new int[size, size];
    }

    public void AddNode(Node node)
    {

    }

    public void AddEdge(int source, int destination)
    {

    }

    public bool CheckEdge(int source, int destination) 
    {
        return true;
    }
}
