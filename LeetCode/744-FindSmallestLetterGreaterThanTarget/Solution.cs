namespace _744_FindSmallestLetterGreaterThanTarget
{
    internal class Solution
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            int? maxDiff = null;
            char? charMaxDiff = null;
            int targetInt = CharToInt(target);

            for (int i = 0; i < letters.Length; i++)
            {
                int diff = CharToInt(letters[i]) - targetInt;
                if (diff < 0)
                {
                    diff = 26 + diff;
                }

                if (diff == 0)
                {
                    continue;
                }
                if (diff == 1)
                {
                    return letters[i];
                }

                if (!maxDiff.HasValue || diff < maxDiff)
                {
                    maxDiff = diff;
                    charMaxDiff = letters[i];
                }
            }

            return charMaxDiff.Value;
        }

        private int CharToInt(char c)
        {
            return c - 'a';
        }
    }
}
