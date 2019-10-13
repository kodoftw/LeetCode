using Graph;
using System.Collections.Generic;
using Xunit;

namespace _133_CloneGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            var node = Builder.CreateUndirectedGraph(new Dictionary<int, IList<int>>()
            {
                {1, new List<int>() {2,3,4} },
                {2, new List<int>() {1,3,4} },
                {3, new List<int>() {1,2,4} },
                {4, new List<int>() {1,2,3} }
            }, 1);
            var res = solution.CloneGraph(node);
            Assert.NotSame(node, res);
            Assert.Equal(Printer.PrintUndirectedGraph(node), Printer.PrintUndirectedGraph(res));
            System.Console.WriteLine(Printer.PrintUndirectedGraph(node));
        }
    }
}
