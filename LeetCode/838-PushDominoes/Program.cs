using Xunit;

namespace _838_PushDominoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal("LL.RR.LLRRLL..", new Solution().PushDominoes(".L.R...LR..L.."));
            Assert.Equal("RR.L", new Solution().PushDominoes("RR.L"));
        }
    }
}
