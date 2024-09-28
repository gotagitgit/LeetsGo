using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Sorting;

internal class MergeSortedLinkedList
{
    public static void Run()
    {
        var listNode1 = CreateListNodeFromArray([1]);

        var listNode2 = CreateListNodeFromArray([1, 3, 4]);

        var result = MergeTwoLists(null, null);
    }

    private static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        //if (list1 is null && list2 is null) return null;

        //if (list1 is null && list2 is not null) return list2;

        //if (list1 is not null && list2 is null) return list1;

        var list = new List<int>();

        ListNodeToNumbers(list1, list);

        ListNodeToNumbers(list2, list);

        if (list.Count == 0) return null;

        list.Sort();

        return CreateListNodeFromArray(list.ToArray());
    }    

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    private static void ListNodeToNumbers(ListNode listNode, List<int> numbers)
    {
        if(listNode is null) return;

        numbers.Add(listNode.val);

        if (listNode.next is not null)
            ListNodeToNumbers(listNode.next, numbers);         
    }

    private static ListNode CreateListNodeFromArray(int[] numbers)
    {
        var numberList = numbers.ToList();

        var value = numberList[0];

        if (numbers.Length > 1)
        {
            numberList.RemoveAt(0);

            var nextListNode = CreateListNodeFromArray(numberList.ToArray());

            return new ListNode(value, nextListNode);
        }        

        return new ListNode(numbers[0]);
    }
}
