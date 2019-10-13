using Xunit;

namespace _890_FindAndReplacePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(new[] { "mee", "aqq" }, new Solution().FindAndReplacePattern(new[] { "abc", "deq", "mee", "aqq", "dkd", "ccc" }, "abb"));
        }
    }
}
