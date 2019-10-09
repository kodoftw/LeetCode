using Xunit;

namespace _884_UncommonWordsFromTwoSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(new[] { "sweet", "sour" }, solution.UncommonFromSentences("this apple is sweet", "this apple is sour"));
            Assert.Equal(new[] { "banana" }, solution.UncommonFromSentences("apple apple", "banana"));
        }
    }
}
