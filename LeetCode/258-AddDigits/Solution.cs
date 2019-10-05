namespace _258_AddDigits
{
    internal class Solution
    {
        public int AddDigits(int num)
        {
            return 1 + (num - 1) % 9;
        }
    }
}
