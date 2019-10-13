namespace _75_SortColors
{
    internal class Solution
    {
        public void SortColors(int[] nums)
        {
            if (nums == null)
                return;

            int zero = 0,
                one = 0,
                two = nums.Length - 1;

            while (one <= two)
            {
                switch (nums[one])
                {
                    case 0:
                        SwapPositions(nums, zero++, one++);
                        break;

                    case 1:
                        one++;
                        break;

                    default:
                        SwapPositions(nums, one, two--);
                        break;
                }
            }
        }

        private void SwapPositions(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
