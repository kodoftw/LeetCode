using System.Collections.Generic;
using System.Linq;

namespace _756_PyramidTransitionMatrix
{
    internal class Solution
    {
        private IDictionary<string, HashSet<string>> allowedHash = new Dictionary<string, HashSet<string>>();

        public bool PyramidTransition(string bottom, IList<string> allowed)
        {
            if (!allowedHash.Any())
            {
                foreach (var triplet in allowed)
                {
                    var key = triplet.Substring(0, 2);
                    var value = triplet[2].ToString();
                    if (allowedHash.ContainsKey(key))
                    {
                        allowedHash[key].Add(value);
                    }
                    else
                    {
                        allowedHash.Add(key, new HashSet<string>() { value });
                    }
                }
            }

            if (bottom.Length == 1)
            {
                return true;
            }

            var newBottoms = MoveUpOneRow(bottom, allowed);

            if (newBottoms == null)
            {
                return false;
            }

            if (!newBottoms.Any())
            {
                return false;
            }

            if (newBottoms.Count == 1)
            {
                return true;
            }

            foreach (var newBottom in newBottoms)
            {
                if (PyramidTransition(newBottom, allowed))
                {
                    return true;
                }
            }

            return false;
        }

        private IList<string> MoveUpOneRow(string bottom, IList<string> allowed)
        {
            var newBottoms = new List<string>();

            for (int i = 0; i < bottom.Length - 1; i++)
            {
                var tuple = bottom.Substring(i, 2);

                if (!allowedHash.ContainsKey(tuple))
                {
                    return null;
                }

                var matchingTriplets = allowedHash[tuple].ToList();

                if (i == 0)
                {
                    newBottoms = matchingTriplets;
                }
                else
                {
                    newBottoms = matchingTriplets.SelectMany(x => newBottoms.Select(y => y + x)).ToList();
                }
            }


            return newBottoms;
        }
    }
}
