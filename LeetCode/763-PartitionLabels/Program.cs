using System.Collections.Generic;
using Xunit;

namespace _763_PartitionLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(new List<int>() { 9, 7, 8 }, new Solution().PartitionLabels("ababcbacadefegdehijhklij"));
        }
    }
}
