namespace LinkedList
{
    public class Builder
    {
        public static ListNode CreateLinkedList(int[] array)
        {
            return CreateLinkedList(array, 0);
        }

        private static ListNode CreateLinkedList(int[] array, int index)
        {
            if (index >= array.Length)
            {
                return null;
            }

            var node = new ListNode(array[index]);
            node.next = CreateLinkedList(array, index + 1);

            return node;
        }
    }
}
