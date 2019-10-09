using LinkedList;

namespace _876_MiddleOfTheLinkedList
{
    internal class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            int index = 0;
            var middleNode = head;
            while (head != null)
            {
                head = head.next;
                index++;
                if (isEven(index))
                {
                    middleNode = middleNode.next;
                }
            }

            return middleNode;
        }

        private bool isEven(int x)
        {
            return (x & 1) == 0;
        }
    }
}
