using System.Collections.Generic;

namespace _412_FizzBuzz
{
    internal class Solution
    {
        public IList<string> FizzBuzz(int n)
        {
            int three = 0;
            int five = 0;
            var ret = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                three++;
                five++;
                var str = string.Empty;

                if (three != 3 && five != 5)
                {
                    str = i.ToString();
                }
                else
                {
                    if (three == 3)
                    {
                        str = "Fizz";
                        three = 0;
                    }

                    if (five == 5)
                    {
                        str += "Buzz";
                        five = 0;
                    }
                }

                ret.Add(str);
            }

            return ret;
        }
    }
}
