using System.Collections.Generic;
using System.Linq;

namespace _884_UncommonWordsFromTwoSentences
{
    internal class Solution
    {
        public string[] UncommonFromSentences(string A, string B)
        {
            var ret = new Dictionary<string, int>();

            foreach (var word in (A + " " + B).Split(' '))
            {
                if (ret.ContainsKey(word))
                {
                    ret[word] = ret[word] + 1;
                }
                else
                {
                    ret[word] = 1;
                }
            }

            return ret.Where(_ => _.Value == 1).Select(_ => _.Key).ToArray();
        }
    }
}
