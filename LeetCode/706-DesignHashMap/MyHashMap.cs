namespace _706_DesignHashMap
{
    public class MyHashMap
    {
        private Node[] table;

        /** Initialize your data structure here. */
        public MyHashMap()
        {
            // GetHashedKey(1000000) == 976
            table = new Node[976];
        }

        /** value will always be non-negative. */
        public void Put(int key, int value)
        {
            var hashedKey = GetHashedKey(key);
            if (table[hashedKey] == null)
            {
                table[hashedKey] = new Node(key, value);
                return;
            }

            var node = findPrevNode(table[hashedKey], key);
            if (node.Key == key)
            {
                node.Val = value;
            }
            else if (node.Next == null)
            {
                node.Next = new Node(key, value);
            }
            else
            {
                node.Next.Val = value;
            }
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            var hashedKey = GetHashedKey(key);
            var node = findNode(table[hashedKey], key);

            if (node == null)
            {
                return -1;
            }

            return node.Val;
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            var hashedKey = GetHashedKey(key);
            if (table[hashedKey] == null)
            {
                return;
            }

            var node = findPrevNode(table[hashedKey], key);
            if (node.Key == key)
            {
                table[hashedKey] = node.Next;
                return;
            }

            if (node.Next != null)
            {
                node.Next = node.Next.Next;
            }
        }

        private int GetHashedKey(int key)
        {
            return key >> 10;
        }

        private Node findPrevNode(Node node, int key)
        {
            if (node.Key == key || node.Next == null || node.Next.Key == key)
            {
                return node;
            }

            return findPrevNode(node.Next, key);
        }

        private Node findNode(Node node, int key)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Key == key)
            {
                return node;
            }

            return findNode(node.Next, key);
        }

        private class Node
        {
            public int Key { get; private set; }
            public int Val { get; set; }
            public Node Next { get; set; }

            public Node(int key, int val)
            {
                Key = key;
                Val = val;
            }
        }
    }
}
