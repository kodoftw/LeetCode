using System;
using System.Collections.Generic;

namespace _763_PartitionLabels
{
    internal class Solution
    {
        private class CharOccurrences
        {
            public int First { get; set; }
            public int Last { get; set; }

            public CharOccurrences(int index)
            {
                First = index;
                Last = index;
            }
        }

        private class Partition
        {
            public int Start { get; set; }
            public int End { get; set; }

            public int Size()
            {
                return End - Start + 1;
            }

            public Partition(int start, int end)
            {
                Start = start;
                End = end;
            }
        }

        public IList<int> PartitionLabels(string S)
        {
            if (string.IsNullOrWhiteSpace(S))
            {
                return new List<int>();
            }

            var charOccurrencesMap = new Dictionary<char, CharOccurrences>();
            var charOrderedOccurrences = new List<char>();

            for (int i = 0; i < S.Length; i++)
            {
                var c = S[i];
                if (charOccurrencesMap.ContainsKey(c))
                {
                    charOccurrencesMap[c].Last = i;
                }
                else
                {
                    charOrderedOccurrences.Add(c);
                    charOccurrencesMap[c] = new CharOccurrences(i);
                }
            }

            var partitions = new List<int>();
            Partition partition = null;
            foreach (var c in charOrderedOccurrences)
            {
                var occurrence = charOccurrencesMap[c];
                if (partition == null)
                {
                    partition = new Partition(occurrence.First, occurrence.Last);
                }
                else if (occurrence.First < partition.End)
                {
                    partition.Start = Math.Min(occurrence.First, partition.Start);
                    partition.End = Math.Max(occurrence.Last, partition.End);
                }
                else
                {
                    partitions.Add(partition.Size());
                    partition = new Partition(occurrence.First, occurrence.Last);
                }
            }

            partitions.Add(partition.Size());
            return partitions;
        }
    }
}
