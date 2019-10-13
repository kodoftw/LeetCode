using System;

namespace _470_ImplementRand10UsingRand7
{
    internal class Solution
    {
        public int Rand10()
        {
            int uniformSpace = 40;
            int rand = uniformSpace;
            while (rand >= uniformSpace)
            {
                rand = 7 * (Rand7() - 1) + (Rand7() - 1);
            }

            return rand % 10 + 1;
        }

        private int Rand7()
        {
            var rand = new Random();
            return rand.Next(1, 8);
        }
    }
}
