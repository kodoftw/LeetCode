using System.Linq;
using Xunit;

namespace _811_SubdomainVisitCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(
                (new[] { "9001 discuss.leetcode.com", "9001 leetcode.com", "9001 com" }).OrderBy(_ => _),
                solution.SubdomainVisits(new[] { "9001 discuss.leetcode.com" }).OrderBy(_ => _));
            Assert.Equal(
                (new[] { "901 mail.com", "50 yahoo.com", "900 google.mail.com", "5 wiki.org", "5 org", "1 intel.mail.com", "951 com" }).OrderBy(_ => _),
                solution.SubdomainVisits(new[] { "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" }).OrderBy(_ => _));
        }
    }
}
