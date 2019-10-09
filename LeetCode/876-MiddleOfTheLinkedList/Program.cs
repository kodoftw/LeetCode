using LinkedList;
using Xunit;

namespace _876_MiddleOfTheLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal("3->4->5->NULL", Printer.PrintLinkedList(solution.MiddleNode(Builder.CreateLinkedList(new[] { 1, 2, 3, 4, 5 }))));
        }
    }
}
