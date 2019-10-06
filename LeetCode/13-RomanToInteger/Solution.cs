namespace _13_RomanToInteger
{
    internal class Solution
    {
        public int RomanToInt(string s)
        {
            int sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i != s.Length - 1 && IsSmallerThanNext(s[i], s[i + 1]))
                {
                    sum -= RomanCharToInt(s[i]);
                    continue;
                }

                sum += RomanCharToInt(s[i]);
            }

            return sum;
        }

        private bool IsSmallerThanNext(char a, char b)
        {
            return RomanCharToInt(a) < RomanCharToInt(b);
        }

        private int RomanCharToInt(char c)
        {
            switch (c)
            {
                case 'I':
                    return 1;

                case 'V':
                    return 5;

                case 'X':
                    return 10;

                case 'L':
                    return 50;

                case 'C':
                    return 100;

                case 'D':
                    return 500;

                case 'M':
                    return 1000;
            }

            return 0;
        }
    }
}
