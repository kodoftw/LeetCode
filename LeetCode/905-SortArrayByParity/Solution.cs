namespace _905_SortArrayByParity
{
    internal class Solution
    {
        public int[] SortArrayByParity(int[] A)
        {
            if (A.Length <= 1) return A;

            int odd = 0;
            while (odd < A.Length && isEven(A[odd])) odd++;

            for (int i = odd + 1; i < A.Length; i++)
            {
                if (isEven(A[i]))
                {
                    var temp = A[odd];
                    A[odd] = A[i];
                    A[i] = temp;
                    odd++;
                }
            }

            return A;
        }

        private bool isEven(int x)
        {
            return (x & 1) == 0;
        }
    }
}
