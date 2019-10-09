using System;
using Xunit;

namespace _136_SingleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(1, solution.SingleNumber(new[] { 2, 2, 1 }));
            Assert.Equal(4, solution.SingleNumber(new[] { 4, 1, 2, 1, 2 }));
        }
    }
}
