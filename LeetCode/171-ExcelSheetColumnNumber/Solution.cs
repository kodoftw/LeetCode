namespace _171_ExcelSheetColumnNumber
{
    internal class Solution
    {
        public int TitleToNumber(string s)
        {
            int ret = 0;
            int mult = 1;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                ret += mult * ColumnCharToInt(s[i]);
                mult *= 26;
            }

            return ret;
        }

        private int ColumnCharToInt(char c)
        {
            return c - 64;
        }
    }
}
