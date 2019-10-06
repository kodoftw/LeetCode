namespace _9_PalindromeNumber
{
    internal class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            int[] digits = UnsignedIntToDigits(x);
            int numDigits = digits.Length;

            for (int i = 0; i < numDigits / 2; i++)
            {
                if (digits[i] != digits[numDigits - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        private int[] UnsignedIntToDigits(int x)
        {
            int numDigits = NumberOfDigits(x);
            var arr = new int[numDigits];

            for (int i = 0; i < numDigits; i++)
            {
                arr[i] = x % 10;
                x = x / 10;
            }

            return arr;
        }

        private int NumberOfDigits(int x)
        {
            if (x == 0 || x < 10)
            {
                return 1;
            }
            if (x < 100)
                return 2;
            if (x < 1000)
                return 3;
            if (x < 10000)
                return 4;
            if (x < 100000)
                return 5;
            if (x < 1000000)
                return 6;
            if (x < 10000000)
                return 7;
            if (x < 100000000)
                return 8;
            if (x < 1000000000)
                return 9;
            return 10;
        }
    }
}
