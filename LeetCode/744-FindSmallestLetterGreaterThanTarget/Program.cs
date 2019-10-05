using Xunit;

namespace _744_FindSmallestLetterGreaterThanTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal('c', solution.NextGreatestLetter(new[] { 'c', 'f', 'j' }, 'a'));
            Assert.Equal('f', solution.NextGreatestLetter(new[] { 'c', 'f', 'j' }, 'c'));
            Assert.Equal('f', solution.NextGreatestLetter(new[] { 'c', 'f', 'j' }, 'd'));
            Assert.Equal('j', solution.NextGreatestLetter(new[] { 'c', 'f', 'j' }, 'g'));
            Assert.Equal('c', solution.NextGreatestLetter(new[] { 'c', 'f', 'j' }, 'j'));
            Assert.Equal('c', solution.NextGreatestLetter(new[] { 'c', 'f', 'j' }, 'k'));
        }
    }
}
