namespace _83_RemoveDuplicatesFromSortedList
{
    public class ListNode
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
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
                return head;

            var curr = head;
            while (curr.next != null)
            {
                var next = curr.next;
                if (curr.val == next.val)
                {
                    curr.next = next.next;
                }
                else
                {
                    curr = curr.next;
                }
            }

            return head;
        }
    }
}
