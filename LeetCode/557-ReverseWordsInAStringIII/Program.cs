using Xunit;

namespace _557_ReverseWordsInAStringIII
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal("s'teL ekat edoCteeL tsetnoc", solution.ReverseWords("Let's take LeetCode contest"));
        }
    }
}
