namespace DataStruct.Searches.BST;

public class Node
{
    public Node(int value) : this(value, null, null)
    {
    }

    public Node(int value, Node leftNode, Node rightNode)
    {
        Value = value;
        LeftNode = leftNode;
        RightNode = rightNode;
    }

    public int Value { get; set; }

    public Node LeftNode { get; set; }

    public Node RightNode { get; set; }
}
