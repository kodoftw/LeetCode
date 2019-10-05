using System.Collections.Generic;
using System.Linq;

namespace _414_ThirdMaximumNumber
{
    internal class Solution
    {
        public class MinHeap
        {

            private SortedSet<int> Heap = new SortedSet<int>();

            public void Add(int value)
            {
                Heap.Add(value);
            }

            public bool Contains(int value)
            {
                return Heap.Contains(value);
            }

            public int Min => Heap.First();

            public int Max => Heap.Last();

            public int Size => Heap.Count;

            public void RemoveMin()
            {
                Heap.Remove(Heap.First());
            }
        }

        public int ThirdMax(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return -1;

            var heap = FillMinHeap(nums, 3);

            if (heap.Size < 3)
                return heap.Max;
            else
                return heap.Min;
        }

        private MinHeap FillMinHeap(int[] nums, int size)
        {
            var heap = new MinHeap();

            for (int i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                if (heap.Size < size)
                {
                    heap.Add(num);
                }
                else if (!heap.Contains(num) && heap.Min < num)
                {
                    heap.RemoveMin();
                    heap.Add(num);
                }
            }

            return heap;
        }
    }
}
