using System.Collections.Generic;
using System.Linq;

namespace _784_LetterCasePermutation
{
    internal class Solution
    {
        public IList<string> LetterCasePermutation(string S)
        {
            if (S == null)
            {
                return new List<string>();
            }

            if (S == string.Empty)
            {
                return new List<string>() { S };
            }

            var list = new List<string>();
            var rest = LetterCasePermutation(S.Substring(1));

            var beforeList = new List<string>();

            if (char.IsLetter(S[0]))
            {
                beforeList.Add(char.ToLower(S[0]).ToString());
                beforeList.Add(char.ToUpper(S[0]).ToString());
            }
            else
            {
                beforeList.Add(S[0].ToString());
            }

            if (rest.Any())
            {
                foreach (var perm in rest)
                {
                    foreach (var before in beforeList)
                    {
                        list.Add(before + perm);
                    }
                }
            }
            else
            {
                list = beforeList;
            }

            return list;
        }
    }
}
