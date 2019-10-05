using Xunit;

namespace _706_DesignHashMap
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashMap = new MyHashMap();
            hashMap.Put(1, 1);
            hashMap.Put(2, 2);
            Assert.Equal(1, hashMap.Get(1));
            Assert.Equal(-1, hashMap.Get(3));
            hashMap.Put(2, 1);
            Assert.Equal(1, hashMap.Get(2));
            hashMap.Remove(2);
            Assert.Equal(-1, hashMap.Get(2));
        }
    }
}
