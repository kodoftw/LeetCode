using System.Collections.Generic;

namespace _232_QueueWithStacks
{
    internal class MyQueue
    {
        private Stack<int> Stack;

        /** Initialize your data structure here. */
        public MyQueue()
        {
            Stack = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            var auxStack = new Stack<int>();
            while (Stack.Count != 0)
            {
                auxStack.Push(Stack.Pop());
            }

            Stack.Push(x);
            while (auxStack.Count != 0)
            {
                Stack.Push(auxStack.Pop());
            }
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            return Stack.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            return Stack.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return Stack.Count == 0;
        }
    }

    /**
     * Your MyQueue object will be instantiated and called as such:
     * MyQueue obj = new MyQueue();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Peek();
     * bool param_4 = obj.Empty();
     */
}
