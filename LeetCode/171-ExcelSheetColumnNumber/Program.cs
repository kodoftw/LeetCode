using Xunit;

namespace _171_ExcelSheetColumnNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(1, solution.TitleToNumber("A"));
            Assert.Equal(28, solution.TitleToNumber("AB"));
            Assert.Equal(701, solution.TitleToNumber("ZY"));
        }
    }
}
