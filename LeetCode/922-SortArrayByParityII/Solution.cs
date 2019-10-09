namespace _922_SortArrayByParityII
{
    internal class Solution
    {
        public int[] SortArrayByParityII(int[] A)
        {
            int? wrongEven = null;
            int? wrongOdd = null;

            for (int even = 0, odd = 0; even < A.Length && odd < A.Length;)
            {
                if (!wrongEven.HasValue)
                {
                    if (IsEven(even) && IsOdd(A[even]))
                    {
                        wrongEven = even;
                    }
                    else
                    {
                        even++;
                    }
                }

                if (!wrongOdd.HasValue)
                {
                    if (IsOdd(odd) && IsEven(A[odd]))
                    {
                        wrongOdd = odd;
                    }
                    else
                    {
                        odd++;
                    }
                }

                if (wrongEven.HasValue && wrongOdd.HasValue)
                {
                    var temp = A[wrongEven.Value];
                    A[wrongEven.Value] = A[wrongOdd.Value];
                    A[wrongOdd.Value] = temp;
                    wrongEven = null;
                    wrongOdd = null;
                }
            }

            return A;
        }

        private bool IsEven(int x)
        {
            return (x & 1) == 0;
        }

        private bool IsOdd(int x)
        {
            return !IsEven(x);
        }
    }
}
