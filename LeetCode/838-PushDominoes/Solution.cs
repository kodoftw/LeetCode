using System;
using System.Text;

namespace _838_PushDominoes
{
    internal class Solution
    {
        private StringBuilder Sb = new StringBuilder();

        public string PushDominoes(string dominoes)
        {

            for (int i = 0; i < dominoes.Length; i++)
            {
                var domino = dominoes[i];
                if (domino == '.')
                {
                    continue;
                }

                if (domino == 'L')
                {
                    AppendDominoes('L', i - Sb.Length + 1);
                }
                else
                {
                    FillWithDots(i);
                    PushRight(dominoes, i);

                    i = Sb.Length - 1;
                }
            }

            if (Sb.Length < dominoes.Length)
            {
                AppendDominoes('.', dominoes.Length - Sb.Length);
            }

            return Sb.ToString();
        }

        private void FillWithDots(int index)
        {
            AppendDominoes('.', index - Sb.Length);
        }

        private void AppendDominoes(char c, int len)
        {
            Sb.Append(c, len);
        }

        private void PushRight(string dominoes, int index)
        {
            if (index >= dominoes.Length)
                return;

            int nextL = FindNextPushedDomino(dominoes, index + 1);
            if (nextL == dominoes.Length)
            {
                AppendDominoes('R', nextL - index);
            }
            else if (dominoes[nextL] == 'R')
            {
                AppendDominoes('R', 1);
                PushRight(dominoes, index + 1);
                return;
            }
            else
            {
                int numPushedDominoes = (int)Math.Ceiling((decimal)(nextL - index) / 2);
                AppendDominoes('R', numPushedDominoes);
                if (((nextL - index) & 1) == 0)
                    AppendDominoes('.', 1);
                AppendDominoes('L', numPushedDominoes);
            }
        }

        private int FindNextPushedDomino(string dominoes, int index)
        {
            while (index < dominoes.Length && dominoes[index] == '.')
                index++;

            return index;
        }
    }
}
