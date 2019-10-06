using System.Collections.Generic;

namespace _771_JewelsAndStones
{
    internal class Solution
    {
        public int NumJewelsInStones(string J, string S)
        {
            var jewels = new HashSet<char>();

            foreach (var jewel in J)
            {
                jewels.Add(jewel);
            }

            int numJewels = 0;

            foreach (var letter in S)
            {
                if (jewels.Contains(letter))
                {
                    numJewels++;
                }
            }

            return numJewels;
        }
    }
}
