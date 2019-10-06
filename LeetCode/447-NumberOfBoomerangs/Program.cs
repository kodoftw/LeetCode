using System;
using Xunit;

namespace _447_NumberOfBoomerangs
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(2, solution.NumberOfBoomerangs(new[,] { { 0, 0 }, { 1, 0 }, { 2, 0 } }));
        }
    }
}
