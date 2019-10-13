using Xunit;

namespace _537_ComplexNumberMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal("0+2i", new Solution().ComplexNumberMultiply("1+1i", "1+1i"));
            Assert.Equal("0+-2i", new Solution().ComplexNumberMultiply("1+-1i", "1+-1i"));
        }
    }
}
