namespace _1041_RobotBoundedInCircle
{
    internal class Solution
    {
        public bool IsRobotBounded(string instructions)
        {
            int x = 0,
                y = 0,
                direction = 0;

            foreach (var instruction in instructions)
            {
                switch (instruction)
                {
                    case 'G':
                        if (direction == 0) y++;
                        else if (direction == 1) x++;
                        else if (direction == 2) y--;
                        else x--;
                        break;

                    case 'L':
                        direction = (direction + 3) % 4;
                        break;

                    case 'R':
                        direction = (direction + 1) % 4;
                        break;
                }
            }

            return (x == 0 && y == 0) || direction != 0;
        }
    }
}
