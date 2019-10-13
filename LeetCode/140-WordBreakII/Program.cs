using System.Collections.Generic;
using Xunit;

namespace _140_WordBreakII
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(
                SortList(new List<string>() { "cats and dog", "cat sand dog" }),
                SortList(new Solution().WordBreak("catsanddog", new List<string>() { "cat", "cats", "and", "sand", "dog" })));
            Assert.Equal(
                SortList(new List<string>() { "pine apple pen apple", "pineapple pen apple", "pine applepen apple" }),
                SortList(new Solution().WordBreak("pineapplepenapple", new List<string>() { "apple", "pen", "applepen", "pine", "pineapple" })));
            Assert.Equal(
                SortList(new List<string>()),
                SortList(new Solution().WordBreak("catsandog", new List<string>() { "cats", "dog", "sand", "and", "cat" })));
        }

        private static IList<string> SortList(IList<string> list)
        {
            ((List<string>)list).Sort();
            return list;
        }
    }
}
