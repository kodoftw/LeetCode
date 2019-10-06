using System.Linq;

namespace _520_Detect_Capital
{
    internal class Solution
    {
        public bool DetectCapitalUse(string word)
        {
            if (word.Length <= 1)
            {
                return true;
            }

            if (IsUpperCase(word[0]))
            {
                if (IsUpperCase(word[1]))
                {
                    return word.Substring(1).All(IsUpperCase);
                }
                else
                {
                    return word.Substring(1).All(IsLowerCase);
                }
            }
            else
            {
                return word.All(IsLowerCase);
            }
        }

        private bool IsLowerCase(char c)
        {
            return c >= 'a';
        }

        private bool IsUpperCase(char c)
        {
            return !IsLowerCase(c);
        }
    }
}
