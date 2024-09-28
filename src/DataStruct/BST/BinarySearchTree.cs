using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct.BST;

public class BinarySearchTree
{
    public Node Root { get; private set; }

    public void Insert(Node node)
    {
        Root = InsertNode(Root, node);
    }

    public void Delete(int value)
    {
        if (Search(value))
            _ = DeleteNode(Root, value);
        else
            throw new ArgumentException($"Node value of {value} is not found in tree");
    }

    private Node DeleteNode(Node node, int value)
    {
        if (node == null)
            return node;
        else if (value > node.Value)
            node.RightNode = DeleteNode(node.RightNode, value);
        else if (value < node.Value)
            node.LeftNode = DeleteNode(node.LeftNode, value);
        else // Node is found
        {
            // Delete if leaf node
            if (node.LeftNode == null && node.RightNode == null)
                node = null;
            else if (node.RightNode != null)
            {
                node.Value = GetSuccessor(node);
                node.RightNode = DeleteNode(node.RightNode, node.Value);
            }
            else
            {
                node.Value = GetPredecessor(node);
                node.LeftNode = DeleteNode(node.LeftNode, node.Value);
            }
        }

        return node;
    }

    private int GetPredecessor(Node node)
    {
        node = node.LeftNode;

        while (node.RightNode != null)
        {
            node = node.RightNode;
        }

        return node.Value;  
    }

    // Find the node on the right side of root with the least value
    private int GetSuccessor(Node node)
    {
        // right node becomes the root node by default
        node = node.RightNode;
        
        // If left node has value then that becomes the root
        while (node.LeftNode != null)
        {
            node = node.LeftNode;
        }

        return node.Value;
    }

    public List<int> GetTreeValues()
    {
        var values = new List<int>();

        GetNodeValue(Root, values);

        return values;
    }

    public bool Search(int value)
    {
        return SearchNodes(Root, value);
    }    

    private bool SearchNodes(Node node, int value)
    {
        if (node == null)
            return false;        
        else if (node.Value == value)
            return true;
        else if (value > node.Value)
            return SearchNodes(node.RightNode, value);
        else if (value < node.Value)
            return SearchNodes(node.LeftNode, value);
        
        return false;
    }

    private Node InsertNode(Node root, Node node)
    {
        if (root == null)
        {
            root = node;

            return root;
        }           
        else if (node.Value <  root.Value)
        {
            root.LeftNode = InsertNode(root.LeftNode, node);
        }
        else
        {
            root.RightNode = InsertNode(root.RightNode, node);
        }

        return root;
    }

    private static void GetNodeValue(Node node, List<int> values)
    {
        if (node != null)
        {
            GetNodeValue(node.LeftNode, values);
            values.Add(node.Value);
            GetNodeValue(node.RightNode, values);
        }
    }
}