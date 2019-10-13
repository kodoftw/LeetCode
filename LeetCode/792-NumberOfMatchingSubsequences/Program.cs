using Xunit;

namespace _792_NumberOfMatchingSubsequences
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(3, solution.NumMatchingSubseq("abcde", new[] { "a", "bb", "acd", "ace" }));
        }
    }
}
