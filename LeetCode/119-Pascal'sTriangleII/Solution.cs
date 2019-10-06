using System.Collections.Generic;

namespace _119_Pascal_sTriangleII
{
    internal class Solution
    {
        public IList<int> GetRow(int rowIndex)
        {
            var numElementsInRow = rowIndex + 1;
            var row = new int[numElementsInRow];
            row[0] = 1;

            for (int i = 1; i < numElementsInRow; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    row[j] += row[j - 1];
                }
            }

            return row;
        }
    }
}
