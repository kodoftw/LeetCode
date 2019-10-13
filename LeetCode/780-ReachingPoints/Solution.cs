namespace _780_ReachingPoints
{
    internal class Solution
    {
        public bool ReachingPoints(int sx, int sy, int tx, int ty)
        {
            (tx, ty) = ReduceTargetsFromEnd(sx, sy, tx, ty);

            return (sx == tx && sy <= ty && IsDivisibleBy(ty - sy, sx))
                || (sy == ty && sx <= tx && IsDivisibleBy(tx - sx, sy));
        }

        private (int, int) ReduceTargetsFromEnd(int sx, int sy, int tx, int ty)
        {
            while (sx < tx && sy < ty)
            {
                if (ty > tx)
                    ty %= tx;
                else
                    tx %= ty;
            }

            return (tx, ty);
        }

        private bool IsDivisibleBy(int a, int b)
        {
            return (a % b) == 0;
        }
    }
}
