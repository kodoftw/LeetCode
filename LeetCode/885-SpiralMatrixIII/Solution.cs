namespace _885_SpiralMatrixIII
{
    internal class Solution
    {

        private enum Direction
        {
            East,
            South,
            West,
            North
        }

        public int[][] SpiralMatrixIII(int R, int C, int r0, int c0)
        {
            var ret = new int[R * C][];
            int count = 0;

            var directions = new Direction[4]
            {
                Direction.East,
                Direction.South,
                Direction.West,
                Direction.North
            };

            var currDirection = directions[0];
            int width = 1;
            int height = 1;

            while (count < R * C)
            {
                int numSteps = NumSteps(currDirection, width, height);
                for (int i = 0; i < numSteps; i++)
                {
                    if (IsInGrid(R, C, r0, c0))
                    {
                        ret[count] = new int[] { r0, c0 };
                        count++;
                    }

                    (r0, c0) = NextGridPosition(r0, c0, currDirection);
                }

                (currDirection, width, height) = UpdateDirectionWidthHeight(currDirection, width, height);
            }

            return ret;
        }

        private int NumSteps(Direction dir, int width, int height)
        {
            switch (dir)
            {
                case Direction.East:
                case Direction.West:
                    return width;

                case Direction.North:
                case Direction.South:
                    return height;
            }

            return 0;
        }

        private bool IsInGrid(int R, int C, int r, int c)
        {
            return r >= 0 && c >= 0 && r < R && c < C;
        }

        private (int, int) NextGridPosition(int r, int c, Direction dir)
        {
            switch (dir)
            {
                case Direction.East:
                    return (r, c + 1);

                case Direction.West:
                    return (r, c - 1);

                case Direction.North:
                    return (r - 1, c);

                case Direction.South:
                    return (r + 1, c);
            }

            return (r, c);
        }

        private (Direction, int, int) UpdateDirectionWidthHeight(Direction dir, int width, int height)
        {

            switch (dir)
            {
                case Direction.East:
                    return (Direction.South, width + 1, height);

                case Direction.West:
                    return (Direction.North, width + 1, height);

                case Direction.North:
                    return (Direction.East, width, height + 1);

                case Direction.South:
                    return (Direction.West, width, height + 1);
            }

            return (dir, width, height);
        }
    }
}
