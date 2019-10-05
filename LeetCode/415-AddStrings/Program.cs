using System;
using Xunit;

namespace _415_AddStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var addStrings = new Solution();

            Assert.Equal("0", addStrings.AddStrings("0", "0"));
            Assert.Equal("178", addStrings.AddStrings("123", "55"));
            Assert.Equal("145905", addStrings.AddStrings("58473", "87432"));
        }
    }
}
