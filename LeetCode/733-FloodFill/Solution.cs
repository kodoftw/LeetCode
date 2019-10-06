namespace _733_FloodFill
{
    internal class Solution
    {
        public int[,] FloodFill(int[,] image, int sr, int sc, int newColor)
        {
            int numRows = image.GetLength(0);
            int numCols = image.GetLength(1);
            var sourceColor = image[sr, sc];

            if (sourceColor == newColor)
            {
                return image;
            }

            FloodFill(image, sr, sc, numRows, numCols, newColor, sourceColor);
            return image;
        }

        private void FloodFill(int[,] image, int sr, int sc, int nr, int nc, int newColor, int sourceColor)
        {
            if (IsOutsideImage(sr, sc, nr, nc))
            {
                return;
            }

            if (image[sr, sc] != sourceColor)
            {
                return;
            }

            image[sr, sc] = newColor;

            FloodFill(image, sr - 1, sc, nr, nc, newColor, sourceColor);
            FloodFill(image, sr + 1, sc, nr, nc, newColor, sourceColor);
            FloodFill(image, sr, sc - 1, nr, nc, newColor, sourceColor);
            FloodFill(image, sr, sc + 1, nr, nc, newColor, sourceColor);
        }

        private bool IsOutsideImage(int sr, int sc, int nr, int nc)
        {
            return sr >= nr || sc >= nc || sr < 0 || sc < 0;
        }
    }
}
