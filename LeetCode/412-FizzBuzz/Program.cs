using Xunit;

namespace _412_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" },
                solution.FizzBuzz(15));
        }
    }
}
