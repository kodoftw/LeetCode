namespace _832_FlippingAnImage
{
    internal class Solution
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            return Invert(Flip(A));
        }

        private int[][] Flip(int[][] img)
        {
            for (int i = 0; i < img.Length; i++)
            {
                var row = img[i];

                for (int j = 0; j < row.Length / 2; j++)
                {
                    var rightIndex = row.Length - 1 - j;

                    var temp = row[j];
                    row[j] = row[rightIndex];
                    row[rightIndex] = temp;
                }
            }

            return img;
        }

        private int[][] Invert(int[][] img)
        {
            for (int i = 0; i < img.Length; i++)
            {
                var row = img[i];

                for (int j = 0; j < row.Length; j++)
                {
                    if (row[j] == 1)
                        row[j] = 0;
                    else
                        row[j] = 1;
                }
            }

            return img;
        }
    }
}
