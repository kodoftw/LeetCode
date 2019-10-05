using System.Text;

namespace _824_GoatLatin
{
    internal class Solution
    {
        public string ToGoatLatin(string s)
        {
            if (s == null)
            {
                return null;
            }

            var ret = new StringBuilder();

            var words = s.Split(' ');
            int a = 1;

            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];

                if (!IsVowel(word[0]))
                {
                    ret.Append(word.Substring(1));
                    ret.Append(word[0]);
                }
                else
                {
                    ret.Append(word);
                }

                ret.Append("ma");
                ret.Append('a', a++);

                if (i != words.Length - 1)
                {
                    ret.Append(' ');
                }
            }

            return ret.ToString();
        }

        private bool IsVowel(char c)
        {
            c = char.ToLower(c);
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }
    }
}
