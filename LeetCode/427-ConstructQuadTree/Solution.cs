namespace _427_ConstructQuadTree
{
    internal class Node
    {
        public bool val;
        public bool isLeaf;
        public Node topLeft;
        public Node topRight;
        public Node bottomLeft;
        public Node bottomRight;

        public Node() { }
        public Node(bool _val, bool _isLeaf, Node _topLeft, Node _topRight, Node _bottomLeft, Node _bottomRight)
        {
            val = _val;
            isLeaf = _isLeaf;
            topLeft = _topLeft;
            topRight = _topRight;
            bottomLeft = _bottomLeft;
            bottomRight = _bottomRight;
        }
    }

    internal class Solution
    {
        public Node Construct(int[][] grid)
        {
            return Construct(grid, 0, 0, grid.Length);
        }

        private Node Construct(int[][] grid, int row, int col, int size)
        {
            if (AreAllElementsTheSame(grid, row, col, size))
            {
                return new Node()
                {
                    val = grid[row][col] == 1 ? true : false,
                    isLeaf = true
                };
            }
            else
            {
                var newSize = size / 2;
                return new Node()
                {
                    isLeaf = false,
                    topLeft = Construct(grid, row, col, newSize),
                    topRight = Construct(grid, row, col + newSize, newSize),
                    bottomLeft = Construct(grid, row + newSize, col, newSize),
                    bottomRight = Construct(grid, row + newSize, col + newSize, newSize)
                };
            }
        }

        private bool AreAllElementsTheSame(int[][] grid, int row, int col, int size)
        {
            var value = grid[row][col];

            for (int i = row; i < (row + size); i++)
            {
                for (int j = col; j < (col + size); j++)
                {
                    if (grid[i][j] != value) return false;
                }
            }

            return true;
        }
    }
}
