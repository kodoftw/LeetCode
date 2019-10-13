using System;

namespace _380_InsertDeleteGetRandomO_1_
{
    public class RandomizedSet
    {
        private class Hash
        {
            public int Count { get; private set; }
            public LinkedList Head { get; private set; }
            public LinkedList Tail { get; private set; }

            public bool Add(int val)
            {
                var (node, index) = FindNodeByValue(val);
                if (node != null)
                {
                    return false;
                }

                var element = new LinkedList(val);
                AddNode(element);
                return true;
            }

            private void AddNode(LinkedList node)
            {
                if (Head == null)
                {
                    Head = node;
                    Tail = node;
                }
                else
                {
                    Tail.Next = node;
                    node.Prev = Tail;
                    Tail = node;
                }

                Count++;
            }

            public bool Remove(int val)
            {
                if (Head == null)
                    return false;

                var (node, index) = FindNodeByValue(val);
                if (node == null)
                {
                    return false;
                }

                RemoveNode(node);
                return true;
            }

            private (LinkedList, int) FindNodeByValue(int val)
            {
                var node = Head;
                int index = node == null ? -1 : 0;

                while (node != null && node.Val != val)
                {
                    node = node.Next;
                    index++;
                }

                return (node, index);
            }

            private void RemoveNode(LinkedList node)
            {
                SetPrevNextToNext(node);
                SetNextPrevToPrev(node);
                Count--;
            }

            private void SetPrevNextToNext(LinkedList node)
            {
                if (node.Prev != null)
                {
                    node.Prev.Next = node.Next;
                }
                else
                {
                    Head = node.Next;
                }
            }

            private void SetNextPrevToPrev(LinkedList node)
            {
                if (node.Next != null)
                {
                    node.Next.Prev = node.Prev;
                }
                else
                {
                    Tail = node.Prev;
                }
            }

            public int GetByIndex(int index)
            {
                if (index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }

                var node = Head;
                while (index-- > 0)
                {
                    node = node.Next;
                }

                return node.Val;
            }
        }

        private class LinkedList
        {
            public int Val { get; set; }
            public LinkedList Prev { get; set; }
            public LinkedList Next { get; set; }

            public LinkedList(int val)
            {
                Val = val;
            }
        }

        private Random Rng = new Random();
        private Hash Hashes = new Hash();
        private Hash[] Data = new Hash[32];

        /** Initialize your data structure here. */
        public RandomizedSet()
        {

        }

        /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
        public bool Insert(int val)
        {
            var key = GenerateKey(val);
            if (Data[key] == null)
            {
                Data[key] = new Hash();
                Hashes.Add(key);
            }

            return Data[key].Add(val);
        }

        private int GenerateKey(int val)
        {
            return val & 31;
        }

        /** Removes a value from the set. Returns true if the set contained the specified element. */
        public bool Remove(int val)
        {
            var key = GenerateKey(val);

            if (Data[key] == null)
            {
                return false;
            }

            var wasRemoved = Data[key].Remove(val);
            if (Data[key].Count == 0)
            {
                Hashes.Remove(key);
                Data[key] = null;
            }

            return wasRemoved;
        }

        int numGets = 0;
        /** Get a random element from the set. */
        public int GetRandom()
        {
            var hashIndex = Rng.Next(0, Hashes.Count);
            var selectedHashIndex = Hashes.GetByIndex(hashIndex);
            var selectedHash = Data[selectedHashIndex];

            var elementIndex = Rng.Next(0, selectedHash.Count);
            return selectedHash.GetByIndex(elementIndex);
        }
    }

}
