using System.Text;

namespace _917_ReverseOnlyLetters
{
    internal class Solution
    {
        public string ReverseOnlyLetters(string S)
        {
            int i = 0, j = S.Length - 1;
            var sb = new StringBuilder();

            for (; i < S.Length; i++)
            {
                if (!isLetter(S[i]))
                {
                    sb.Append(S[i]);
                    continue;
                }

                while (j >= 0 && !isLetter(S[j])) j--;

                sb.Append(S[j]);
                j--;
            }

            return sb.ToString();
        }

        private bool isLetter(char c)
        {
            return char.IsLetter(c);
        }
    }
}
