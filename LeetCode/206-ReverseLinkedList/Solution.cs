namespace _206_ReverseLinkedList
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

        public ListNode ReverseList(ListNode head)
        {
            return ReverseListAux(head, null);
        }

        private ListNode ReverseListAux(ListNode head, ListNode newHead)
        {
            if (head == null)
            {
                return newHead;
            }

            var next = head.next;
            head.next = newHead;
            return ReverseListAux(next, head);
        }
    }
}
