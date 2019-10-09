using LinkedList;
using Xunit;

namespace _83_RemoveDuplicatesFromSortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal("1->2->NULL", Printer.PrintLinkedList(solution.DeleteDuplicates(Builder.CreateLinkedList(new[] { 1, 1, 2 }))));
            Assert.Equal("1->2->3->NULL", Printer.PrintLinkedList(solution.DeleteDuplicates(Builder.CreateLinkedList(new[] { 1, 1, 2, 3, 3 }))));
        }

    }
}
