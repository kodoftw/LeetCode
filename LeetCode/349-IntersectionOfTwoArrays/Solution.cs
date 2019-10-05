using System.Collections.Generic;
using System.Linq;

namespace _349_IntersectionOfTwoArrays
{
    internal class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            int[] smaller = nums1.Length < nums2.Length ? nums1 : nums2;
            int[] bigger = nums1.Length < nums2.Length ? nums2 : nums1;

            var smallerSet = new HashSet<int>(smaller);
            var ret = new HashSet<int>();

            foreach (var elm in bigger)
            {
                if (smallerSet.Contains(elm))
                {
                    ret.Add(elm);
                }
            }

            return ret.ToArray();
        }
    }
}
