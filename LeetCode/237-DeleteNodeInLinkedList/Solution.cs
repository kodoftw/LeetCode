using LinkedList;

namespace _237_DeleteNodeInLinkedList
{
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
