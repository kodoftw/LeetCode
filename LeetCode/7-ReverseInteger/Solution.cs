using System;
using System.Linq;

namespace _7_ReverseInteger
{
    internal class Solution
    {
        public int Reverse(int x)
        {
            bool isNegative = x < 0;
            var value = isNegative ? -x : x;

            int reversed;
            if (!Int32.TryParse(ReverseStr(value.ToString()), out reversed))
            {
                return 0;
            }

            return isNegative ? -reversed : reversed;
        }

        private string ReverseStr(string str)
        {
            if (str.Length == 1)
                return str;

            return str.Last() + ReverseStr(str.Substring(0, str.Length - 1));
        }
    }
}
