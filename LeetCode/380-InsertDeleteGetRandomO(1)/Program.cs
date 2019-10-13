using Xunit;

namespace _380_InsertDeleteGetRandomO_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomizedSet = new RandomizedSet();

            Assert.True(randomizedSet.Insert(1));
            Assert.False(randomizedSet.Remove(2));
            Assert.True(randomizedSet.Insert(2));
            Assert.Contains(randomizedSet.GetRandom(), new[] { 1, 2 });
            Assert.True(randomizedSet.Remove(1));
            Assert.False(randomizedSet.Insert(2));
            Assert.Equal(2, randomizedSet.GetRandom());
        }
    }
}
