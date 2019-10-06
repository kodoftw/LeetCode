namespace _709_ToLowerCase
{
    internal class Solution
    {
        public string ToLowerCase(string str)
        {
            var output = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 'A') && str[i] <= 'Z')
                {
                    output[i] = (char)((int)str[i] + 32);
                }
                else
                {
                    output[i] = str[i];
                }
            }

            return new string(output);
        }
    }
}
