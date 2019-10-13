namespace _535_EncodeAndDecodeTinyURL
{
    class Program
    {
        static void Main(string[] args)
        {
            var codec = new Codec();
            codec.decode(codec.encode("https://leetcode.com/problems/design-tinyurl"));
        }
    }
}
