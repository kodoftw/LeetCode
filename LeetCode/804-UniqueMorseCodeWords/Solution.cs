using System.Collections.Generic;
using System.Text;

namespace _804_UniqueMorseCodeWords
{
    internal class Solution
    {
        private List<string> MorseCodeMap = new List<string>() {
            ".-","-...","-.-.","-..",".","..-.","--.",
            "....","..",".---","-.-",".-..","--","-.",
            "---",".--.","--.-",".-.","...","-","..-",
            "...-",".--","-..-","-.--","--.."
        };

        public int UniqueMorseRepresentations(string[] words)
        {
            var transformations = new HashSet<string>();

            foreach (var word in words)
            {
                transformations.Add(transformWord(word));
            }

            return transformations.Count;
        }

        private string transformWord(string word)
        {
            var output = new StringBuilder();

            foreach (var ch in word)
            {
                var index = getCharMorseIndex(ch);
                output.Append(MorseCodeMap[index]);
            }

            return output.ToString();
        }

        private int getCharMorseIndex(char ch)
        {
            return (int)ch - 97;
        }
    }
}
