using Xunit;

namespace _206_ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal("5->4->3->2->1->NULL", PrintLinkedList(solution.ReverseList(CreateLinkedList(new[] { 1, 2, 3, 4, 5 }))));
        }

        private static ListNode CreateLinkedList(int[] array, int index = 0)
        {
            if (index >= array.Length)
            {
                return null;
            }

            var node = new ListNode(array[index]);
            node.next = CreateLinkedList(array, index + 1);

            return node;
        }

        private static string PrintLinkedList(ListNode node)
        {
            if (node == null)
            {
                return "NULL";
            }

            var rest = PrintLinkedList(node.next);
            var restString = string.IsNullOrEmpty(rest) ? string.Empty : $"->{rest}";

            return $"{node.val}{restString}";
        }
    }
}
