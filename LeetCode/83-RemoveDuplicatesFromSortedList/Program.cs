using Xunit;

namespace _83_RemoveDuplicatesFromSortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal("1->2", PrintLinkedList(solution.DeleteDuplicates(CreateLinkedList(new[] { 1, 1, 2 }))));
            Assert.Equal("1->2->3", PrintLinkedList(solution.DeleteDuplicates(CreateLinkedList(new[] { 1, 1, 2, 3, 3 }))));
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
                return string.Empty;
            }

            var rest = PrintLinkedList(node.next);
            var restString = string.IsNullOrEmpty(rest) ? string.Empty : $"->{rest}";

            return $"{node.val}{restString}";
        }
    }
}
