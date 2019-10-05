using Xunit;

namespace _824_GoatLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal("Imaa peaksmaaa oatGmaaaa atinLmaaaaa", solution.ToGoatLatin("I speak Goat Latin"));
            Assert.Equal(
                "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa",
                solution.ToGoatLatin("The quick brown fox jumped over the lazy dog"));
        }
    }
}
