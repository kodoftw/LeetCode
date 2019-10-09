using LinkedList;
using Xunit;

namespace _237_DeleteNodeInLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            var root1 = Builder.CreateLinkedList(new[] { 4, 5, 1, 9 });
            solution.DeleteNode(root1.next);
            Assert.Equal("4->1->9->NULL", Printer.PrintLinkedList(root1));

            var root2 = Builder.CreateLinkedList(new[] { 4, 5, 1, 9 });
            solution.DeleteNode(root2.next.next);
            Assert.Equal("4->5->9->NULL", Printer.PrintLinkedList(root2));
        }
    }
}
