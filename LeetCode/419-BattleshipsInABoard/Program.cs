using Xunit;

namespace _419_BattleshipsInABoard
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(2, new Solution().CountBattleships(new[] {
                new[] {'X', '.', '.', 'X' }, new[] {'.', '.', '.', 'X' }, new[] {'.', '.', '.', 'X' } }));
        }
    }
}
