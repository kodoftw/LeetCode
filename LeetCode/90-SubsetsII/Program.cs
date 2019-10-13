using System.Collections.Generic;
using Xunit;

namespace _90_SubsetsII
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            var expected = new List<IList<int>>()
            {
                new List<int>() {2},
                new List<int>() {1},
                new List<int>() {1, 2, 2},
                new List<int>() {2, 2},
                new List<int>() {1, 2},
                new List<int>() { }
            };
            expected.Sort(SortLists);
            var actual = solution.SubsetsWithDup(new[] { 1, 2, 2 });
            ((List<IList<int>>)actual).Sort(SortLists);
            Assert.Equal(expected, actual);
        }

        private static int SortLists(IList<int> a, IList<int> b)
        {
            if (a.Count == b.Count)
            {
                var firstDiffIndex = FindFirstDifferent(a, b);
                if (!firstDiffIndex.HasValue)
                {
                    return 0;
                }
                return a[firstDiffIndex.Value].CompareTo(b[firstDiffIndex.Value]);
            }

            return a.Count > b.Count ? -1 : 1;
        }

        private static int? FindFirstDifferent(IList<int> a, IList<int> b)
        {
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] != b[i])
                    return i;
            }

            return null;
        }
    }
}
