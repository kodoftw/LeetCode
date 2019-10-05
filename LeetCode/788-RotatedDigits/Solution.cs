namespace _788_RotatedDigits
{
    internal class Solution
    {
        public int RotatedDigits(int N)
        {
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                if (IsValid(i))
                {
                    sum++;
                }
            }

            return sum;
        }

        private bool IsValid(int n)
        {
            if (n < 10)
            {
                return IsValidLessThan10(n);
            }

            bool atLeastOneValid = false;
            while (n > 0)
            {
                var mod10 = n % 10;
                n = n / 10;

                if (mod10 < 10 && IsInvalidLessThan10(mod10))
                {
                    return false;
                }

                if (!atLeastOneValid && IsValidLessThan10(mod10))
                {
                    atLeastOneValid = true;
                }
            }

            return atLeastOneValid;
        }

        private bool IsValidLessThan10(int n)
        {
            return n == 2 || n == 5 || n == 6 || n == 9;
        }

        private bool IsInvalidLessThan10(int n)
        {
            return n == 3 || n == 4 || n == 7;
        }
    }
}
