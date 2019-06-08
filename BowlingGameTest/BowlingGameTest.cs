using System;
using Xunit;

namespace BowlingKata
{
    public static class ExtensionPack
    {
        public static void Times(this int count, Action action)
        {
            for (int i = 0; i < count; i++)
            {
                action();
            }
        }
    }


    public class BowlingGameTest
    {
        [Fact]
        public void TestRollsAllEmpty()
        {
            var game = new BowlingGame();
            Repeat(() => game.Roll(0), 20);

            Assert.Equal(0, game.Score);
        }

        private void Repeat(Action action, int count)
        {
            for (int i = 0; i < count; i++)
            {
                action();
            }
        }
    }
}
