using Xunit;

namespace _917_ReverseOnlyLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal("dc-ba", solution.ReverseOnlyLetters("ab-cd"));
            Assert.Equal("j-Ih-gfE-dCba", solution.ReverseOnlyLetters("a-bC-dEf-ghIj"));
            Assert.Equal("Qedo1ct-eeLg=ntse-T!", solution.ReverseOnlyLetters("Test1ng-Leet=code-Q!"));
        }
    }
}
