namespace _237_DeleteNodeInLinkedList
{
    internal class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }

    internal class Solution
    {
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;

            if (node.next.next == null)
            {
                node.next = null;
                return;
            }

            DeleteNode(node.next);
        }
    }
}
