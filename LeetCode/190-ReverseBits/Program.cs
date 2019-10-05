using System;
using Xunit;

namespace _190_ReverseBits
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(964176192u, solution.ReverseBits(43261596u));
            Assert.Equal(3221225471u, solution.ReverseBits(4294967293u));
        }
    }
}
