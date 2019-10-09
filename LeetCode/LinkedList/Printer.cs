namespace LinkedList
{
    public class Printer
    {
        public static string PrintLinkedList(ListNode node)
        {
            if (node == null)
            {
                return "NULL";
            }

            return $"{node.val}->{PrintLinkedList(node.next)}";
        }
    }
}
