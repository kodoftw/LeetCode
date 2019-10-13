using Xunit;

namespace _319_BulbSwitcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(1, solution.BulbSwitch(3));
        }
    }
}
