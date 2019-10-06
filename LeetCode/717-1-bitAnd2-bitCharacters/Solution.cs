namespace _717_1_bitAnd2_bitCharacters
{
    internal class Solution
    {
        public bool IsOneBitCharacter(int[] bits)
        {
            int numOnes = 0;

            for (int i = bits.Length - 2; i >= 0 && bits[i] != 0; i--)
                numOnes++;

            return (numOnes % 2) == 0;
        }
    }
}
