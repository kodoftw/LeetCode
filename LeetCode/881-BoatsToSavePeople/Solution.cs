using System;

namespace _881_BoatsToSavePeople
{
    internal class Solution
    {
        public int NumRescueBoats(int[] people, int limit)
        {
            Array.Sort(people);
            int numBoats = 0;

            for (int i = 0, j = people.Length - 1; i <= j;)
            {
                numBoats++;
                if (people[j] + people[i] <= limit)
                {
                    i++;
                }

                j--;
            }

            return numBoats;
        }
    }
}
