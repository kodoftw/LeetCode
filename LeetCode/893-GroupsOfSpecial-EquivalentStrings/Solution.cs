using System.Collections.Generic;

namespace _893_GroupsOfSpecial_EquivalentStrings
{
    internal class Solution
    {
        public int NumSpecialEquivGroups(string[] A)
        {
            int numStrings = A.Length;
            var knownGroups = new HashSet<string>();

            for (int i = 0; i < numStrings; i++)
            {
                var group = new Group();
                bool isEven = true;
                for (int j = 0; j < A[i].Length; j++)
                {
                    if (isEven)
                    {
                        group.AddEven(A[i][j]);
                    }
                    else
                    {
                        group.AddOdd(A[i][j]);
                    }
                    isEven = !isEven;
                }

                var hash = group.GetHash();

                knownGroups.Add(hash);
            }

            return knownGroups.Count;
        }

        private class Group
        {
            private int _odds;
            private int _evens;

            public void AddOdd(char c)
            {
                var value = toIntPosition(c);
                if (!containsOdd(value))
                    _odds += value;
            }

            public void AddEven(char c)
            {
                var value = toIntPosition(c);
                if (!containsEven(value))
                    _evens += value;
            }

            public string GetHash()
            {
                return $"{_odds}-{_evens}";
            }

            private int toIntPosition(char c)
            {
                return 1 << (c - 97);
            }

            private bool containsOdd(int value)
            {
                return (_odds & value) == 1;
            }

            private bool containsEven(int value)
            {
                return (_evens & value) == 1;
            }
        }
    }
}
