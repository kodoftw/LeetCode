using System.Collections.Generic;

namespace _811_SubdomainVisitCount
{
    internal class Solution
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            var cpStash = new Dictionary<string, int>();

            foreach (var cpdomain in cpdomains)
            {
                var cpCount = GetCpCountFromCpDomain(cpdomain);
                foreach (var count in cpCount)
                {
                    if (cpStash.ContainsKey(count.Key))
                    {
                        cpStash[count.Key] = cpStash[count.Key] + count.Value;
                    }
                    else
                    {
                        cpStash.Add(count.Key, count.Value);
                    }
                }
            }

            var ret = new List<string>();

            foreach (var cp in cpStash)
            {
                ret.Add($"{cp.Value} {cp.Key}");
            }

            return ret;
        }

        private IDictionary<string, int> GetCpCountFromCpDomain(string cpdomain)
        {
            var cpCount = new Dictionary<string, int>();

            var ss = cpdomain.Split(' ');
            var count = int.Parse(ss[0]);
            var domain = ss[1];

            cpCount.Add(domain, count);

            for (int i = 0; i < domain.Length; i++)
            {
                if (domain[i] == '.')
                {
                    cpCount.Add(domain.Substring(i + 1), count);
                }
            }

            return cpCount;
        }
    }
}
