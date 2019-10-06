namespace _27_RemoveElement
{
    internal class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0) return 0;

            int j = 0;
            for (int i = 0; i < nums.Length;)
            {
                if (nums[i] == val)
                {
                    j = i;
                    while (++i < nums.Length && nums[i] == val);
                    if (i < nums.Length)
                    {
                        nums[j] = nums[i];
                        nums[i] = val;
                    }
                    i = j + 1;
                }
                else
                {
                    i++;
                }
            }

            int ret = 0;
            for (; ret < nums.Length; ret++)
            {
                if (nums[ret] == val)
                {
                    break;
                }
            }

            return ret;
        }
    }
}
