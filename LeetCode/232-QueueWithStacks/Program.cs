using Xunit;

namespace _232_QueueWithStacks
{
    internal class Program
    {
        public static void Main()
        {
            var queue = new MyQueue();

            queue.Push(1);
            queue.Push(2);

            Assert.Equal(1, queue.Peek());
            Assert.Equal(1, queue.Pop());
            Assert.False(queue.Empty());
        }
    }
}
