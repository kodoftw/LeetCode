namespace _707_DesignLinkedList
{
    internal class MyLinkedList
    {
        private class Node
        {
            public int Val { get; set; }
            public Node Next { get; set; }

            public Node(int val)
            {
                Val = val;
            }
        }

        private Node Head;

        private Node Tail;

        /** Initialize your data structure here. */
        public MyLinkedList()
        {

        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (index < 0)
                return -1;

            if (Head == null)
                return -1;

            var node = Head;
            while (index-- > 0)
            {
                node = node.Next;

                if (node == null)
                    return -1;
            }

            return node.Val;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            var newNode = new Node(val);
            newNode.Next = Head;
            Head = newNode;

            if (Tail == null)
                Tail = Head;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            var newNode = new Node(val);
            if (Tail == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else if (Head == Tail)
            {
                Tail = newNode;
                Head.Next = Tail;
            }
            else
            {
                var oldTail = Tail;
                Tail = newNode;
                oldTail.Next = Tail;
            }
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {

            if (index < 0)
            {
                AddAtHead(val);
                return;
            }

            if (index == 0)
            {
                AddAtHead(val);
                return;
            }

            var last = Head;
            var node = Head;
            while (index-- > 0)
            {
                if (node == null)
                    return;

                last = node;
                node = node.Next;
            }

            if (node == null)
            {
                AddAtTail(val);
            }
            else
            {
                var oldNode = node;
                node = new Node(val);
                node.Next = oldNode;
                last.Next = node;
            }
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index < 0 || Head == null)
                return;

            if (index == 0)
            {
                Head = Head.Next;
                return;
            }

            var last = Head;
            var node = Head;
            while (index-- > 0)
            {
                last = node;
                node = node.Next;

                if (node == null)
                    return;
            }

            last.Next = node.Next;
            if (node == Tail)
            {
                Tail = last;
            }
        }
    }
}
