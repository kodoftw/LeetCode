namespace _389_FindTheDifference
{
    internal class Solution
    {
        public char FindTheDifference(string s, string t)
        {
            var len = t.Length;
            var c = t[len - 1];

            for (int i = 0; i < len - 1; i++)
            {
                c ^= s[i];
                c ^= t[i];
            }

            return c;
        }
    }
}
