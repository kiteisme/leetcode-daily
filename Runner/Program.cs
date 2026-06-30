using LeetCode.Med._0001_AddTwoNum;

class Program
{
    static void Main()
    {
        var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

        var s = new Solution();
        var res = s.AddTwoNum(l1, l2);

        Print(res);
    }

    static void Print(ListNode node)
    {
        while (node != null)
        {
            Console.Write(node.val);
            if (node.next != null) Console.Write(" -> ");
            node = node.next;
        }
    }
}