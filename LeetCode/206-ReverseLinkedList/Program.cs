using LinkedList;
using Xunit;

namespace _206_ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal("5->4->3->2->1->NULL", Printer.PrintLinkedList(solution.ReverseList(Builder.CreateLinkedList(new[] { 1, 2, 3, 4, 5 }))));
        }
    }
}
