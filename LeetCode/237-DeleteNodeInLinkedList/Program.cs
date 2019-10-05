using Xunit;

namespace _237_DeleteNodeInLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            var root1 = CreateLinkedList(new[] { 4, 5, 1, 9 });
            solution.DeleteNode(root1.next);
            Assert.Equal("4->1->9->NULL", PrintLinkedList(root1));

            var root2 = CreateLinkedList(new[] { 4, 5, 1, 9 });
            solution.DeleteNode(root2.next.next);
            Assert.Equal("4->5->9->NULL", PrintLinkedList(root2));
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
