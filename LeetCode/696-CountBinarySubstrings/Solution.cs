namespace _696_CountBinarySubstrings
{
    internal class Solution
    {
        public int CountBinarySubstrings(string s)
        {
            int prevRun = 0;
            int curRun = 1;
            int ret = 0;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    curRun++;
                }
                else
                {
                    prevRun = curRun;
                    curRun = 1;
                }

                if (curRun <= prevRun)
                {
                    ret++;
                }
            }

            return ret;
        }
    }
}
