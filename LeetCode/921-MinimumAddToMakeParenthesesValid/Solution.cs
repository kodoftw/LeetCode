using System;

namespace _921_MinimumAddToMakeParenthesesValid
{
    internal class Solution
    {
        public int MinAddToMakeValid(string S)
        {
            int sum = 0;
            int numOpen = 0;

            foreach (var c in S)
            {
                if (c == '(')
                {
                    if (numOpen >= 0)
                    {
                        numOpen++;
                    }
                    else
                    {
                        sum -= numOpen;
                        numOpen = 1;
                    }
                }
                else
                {
                    if (numOpen > 0)
                    {
                        numOpen--;
                    }
                    else if (numOpen == 0)
                    {
                        sum++;
                    }
                }
            }

            sum += Math.Abs(numOpen);

            return sum;
        }
    }
}
