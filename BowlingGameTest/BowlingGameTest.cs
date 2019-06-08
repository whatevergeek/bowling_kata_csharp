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

        [Fact]
        public void TestOnlyRollsSpareInFirstFrame()
        {
            var game = new BowlingGame();
            Repeat(() => game.Roll(5), 2);
            Repeat(() => game.Roll(1), 18);

            Assert.Equal(10 + 1 + 18, game.Score);
        }

        [Fact]
        public void TestOnlyRollsStrikeInFirstFrame()
        {
            var game = new BowlingGame();
            Repeat(() => game.Roll(10), 1);
            Repeat(() => game.Roll(1), 18);

            Assert.Equal(10 + 1 + 1 + 18, game.Score);
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
