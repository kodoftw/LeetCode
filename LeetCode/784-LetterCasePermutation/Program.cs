using System.Collections.Generic;
using Xunit;

namespace _784_LetterCasePermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(Sort(new List<string> { "a1b2", "a1B2", "A1b2", "A1B2" }), Sort(solution.LetterCasePermutation("a1b2")));
            Assert.Equal(Sort(new List<string> { "3z4", "3Z4" }), Sort(solution.LetterCasePermutation("3z4")));
            Assert.Equal(Sort(new List<string> { "12345" }), Sort(solution.LetterCasePermutation("12345")));
        }

        private static IList<string> Sort(IList<string> l)
        {
            ((List<string>)l).Sort();

            return l;
        }
    }
}
