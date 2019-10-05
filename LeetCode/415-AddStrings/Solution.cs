using System;
using System.Collections.Generic;
using System.Text;

namespace _415_AddStrings
{
    internal class Solution
    {
        public string AddStrings(string num1, string num2)
        {
            int smallestLength = Math.Min(num1.Length, num2.Length);
            var sb = new StringBuilder();
            bool hasCarry = false;

            for (int i = 0; i < smallestLength; i++)
            {
                int val1 = ConvertCharToInt(num1[num1.Length - i - 1]);
                int val2 = ConvertCharToInt(num2[num2.Length - i - 1]);
                int sum = val1 + val2 + (hasCarry ? 1 : 0);
                hasCarry = sum > 9;
                var digit = hasCarry ? (sum % 10) : sum;
                sb.Insert(0, digit);
            }

            var sbLeftover = ConvertLeftOver(num1.Length > num2.Length ? num1 : num2, smallestLength, hasCarry);

            return sbLeftover.Append(sb).ToString();
        }

        private int ConvertCharToInt(char c)
        {
            if (c == '0')
                return 0;
            if (c == '1')
                return 1;
            if (c == '2')
                return 2;
            if (c == '3')
                return 3;
            if (c == '4')
                return 4;
            if (c == '5')
                return 5;
            if (c == '6')
                return 6;
            if (c == '7')
                return 7;
            if (c == '8')
                return 8;

            return 9;
        }

        private StringBuilder ConvertLeftOver(string str, int offset, bool hasCarry)
        {
            var sb = new StringBuilder();
            for (int i = str.Length - offset - 1; i >= 0; i--)
            {
                int val = ConvertCharToInt(str[i]);
                int sum = val + (hasCarry ? 1 : 0);
                hasCarry = sum > 9;
                var digit = hasCarry ? (sum % 10) : sum;
                sb.Insert(0, digit);
            }

            if (hasCarry)
            {
                sb.Insert(0, '1');
            }

            return sb;
        }
    }
}
