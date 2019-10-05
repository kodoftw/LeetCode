using Xunit;

namespace _707_DesignLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new MyLinkedList();

            linkedList.AddAtHead(1);
            linkedList.AddAtTail(3);
            linkedList.AddAtIndex(1, 2);
            Assert.Equal(2, linkedList.Get(1));
            linkedList.DeleteAtIndex(1);
            Assert.Equal(3, linkedList.Get(1));
        }
    }
}
