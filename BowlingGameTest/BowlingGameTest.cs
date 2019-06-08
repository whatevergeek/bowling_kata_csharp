using System;
using Xunit;

namespace BowlingKata
{
    public class BowlingGameTest
    {
        [Fact]
        public void TestRollsAllEmpty()
        {
            var game = new BowlingGame();
            Repeat(() => game.Roll(0), 20);

            Assert.Equal(0, game.Score);
        }

        [Fact]
        public void TestRollsAllOne()
        {
            var game = new BowlingGame();
            Repeat(() => game.Roll(1), 20);

            Assert.Equal(20, game.Score);
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
