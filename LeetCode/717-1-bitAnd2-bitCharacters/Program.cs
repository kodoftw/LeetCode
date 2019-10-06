using System;
using Xunit;

namespace _717_1_bitAnd2_bitCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.True(solution.IsOneBitCharacter(new[] { 1, 0, 0 }));
            Assert.False(solution.IsOneBitCharacter(new[] { 1, 1, 1, 0 }));
        }
    }
}
