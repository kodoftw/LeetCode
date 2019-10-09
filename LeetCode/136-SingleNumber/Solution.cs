using System.Linq;

namespace _136_SingleNumber
{
    internal class Solution
    {
        public int SingleNumber(int[] nums)
        {
            return nums.Aggregate(0, (acc, value) => acc ^= value);
        }
    }
}
