namespace _806_NumberOfLinesToWriteString
{
    internal class Solution
    {
        public int[] NumberOfLines(int[] widths, string S)
        {
            if (string.IsNullOrEmpty(S))
            {
                return new[] { 0, 0 };
            }

            int numLines = 1;
            int sum = 0;

            foreach (char c in S)
            {
                var size = sizeOfChar(c, widths);
                if (sum + size > 100)
                {
                    numLines++;
                    sum = size;
                }
                else
                {
                    sum += size;
                }
            }

            return new[] { numLines, sum };
        }

        private int sizeOfChar(char c, int[] widths)
        {
            return widths[c - 97];
        }
    }
}
