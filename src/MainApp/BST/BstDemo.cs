using DataStruct.Searches.BST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.BST;

internal class BstDemo
{
    public static void Run()
    {
        var bst = new BinarySearchTree();

        bst.Insert(new Node(4));
        bst.Insert(new Node(2));
        bst.Insert(new Node(3));
        bst.Insert(new Node(1));
        bst.Insert(new Node(6));
        bst.Insert(new Node(7));
        bst.Insert(new Node(5));

        var values = bst.GetTreeValues();

        Console.WriteLine(string.Join(" -> ", values));

        //bst.Delete(61);

        var newValuesAfterDelete = bst.GetTreeValues();

        Console.WriteLine(string.Join(" -> ", newValuesAfterDelete));
    }
}
