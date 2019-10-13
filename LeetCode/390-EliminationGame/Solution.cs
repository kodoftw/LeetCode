namespace _390_EliminationGame
{
    internal class Solution
    {
        public int LastRemaining(int n)
        {
            int last = 1;
            int step = 1;
            bool isLeft = true;

            while (n > 1)
            {
                if (isLeft || n % 2 == 1)
                {
                    last += step;
                }

                n /= 2;
                step *= 2;
                isLeft = !isLeft;
            }

            return last;
        }
    }
}
