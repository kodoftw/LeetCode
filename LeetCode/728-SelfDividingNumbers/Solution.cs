using System.Collections.Generic;

namespace _728_SelfDividingNumbers
{
    internal class Solution
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            var ret = new List<int>();

            for (int i = left; i <= right; i++)
            {
                if (IsSelfDividing(i))
                    ret.Add(i);
            }

            return ret;
        }

        private bool IsSelfDividing(int n)
        {
            var digits = n.ToString();

            foreach (var charDigit in digits)
            {
                var digit = char.GetNumericValue(charDigit);
                if (digit == 0 || n % digit != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
