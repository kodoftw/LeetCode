using Xunit;

namespace _344_ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            var s1 = new[] { 'h', 'e', 'l', 'l', 'o' };
            solution.ReverseString(s1);
            Assert.Equal(new[] { 'o', 'l', 'l', 'e', 'h' }, s1);

            var s2 = new[] { 'H', 'a', 'n', 'n', 'a', 'h' };
            solution.ReverseString(s2);
            Assert.Equal(new[] { 'h', 'a', 'n', 'n', 'a', 'H' }, s2);
        }
    }
}
