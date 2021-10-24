using System;
using Xunit;

namespace NeighborWarsProject.Tests
{
    public class NeighborWarsMethodsTests
    {
        private NeighborWarsMethods _neighborWarsMethods = new NeighborWarsMethods();

        [Theory]
        [InlineData("Win", 5, 15, true )]
        [InlineData("Draw", 10, 10, true )]
        [InlineData("Lose", 15, 5, true )]
        [InlineData("Win", 3, 17, true )]
        [InlineData("Lose", 12, 8, true )]
        [InlineData("Lose", 20, 0, true )]
        [InlineData("Win", 0, 20, true )]
        [InlineData("", 6, 14, false )]
        [InlineData("", 11, 9, false )]

        public void GameStatus(string gameState, int player, int enemy, bool isGameOver)
        {
            Assert.Equal(gameState, _neighborWarsMethods.GameStatus(player, enemy, isGameOver));
        }

        [Theory]
        [InlineData(20, "Win")]
        [InlineData(5, "Lose")]
        [InlineData(10, "Draw")]
        [InlineData(0, "Double")]
        [InlineData(0, "Have I Won?")]

        public void GameStatusReward(int rewardAmount, string gameState)
        {
            Assert.Equal(rewardAmount, _neighborWarsMethods.GameStatusReward(gameState));
        }

        [Theory]
        [InlineData(true, 100, 20, false)]
        [InlineData(true, 40, 40, false)]
        [InlineData(false, 5, 10, false)]
        [InlineData(false, 100, 20, true)]
        [InlineData(true, 10000, 1, false)]
        [InlineData(false, 0, 0, true)]

        public void CanBuyItem(bool canBuyItem, int coins, int cost, bool isPurchased)
        {
            Assert.Equal(canBuyItem, _neighborWarsMethods.CanBuyItem(coins, cost, isPurchased));
        }

        [Theory]
        [InlineData("Suburbs", 0)]
        [InlineData("Trailer Park", 1)]
        [InlineData("Egypt", 2)]
        [InlineData("Forest", 3)]
        [InlineData("Snow", 4)]
        [InlineData("Island", 5)]
        [InlineData("", 6)]
        [InlineData("", 999)]

        public void RandomLevel(string levelName, int random)
        {
            Assert.Equal(levelName, _neighborWarsMethods.RandomLevel(random));
        }

        [Theory]
        [InlineData(true, 0, 10)]
        [InlineData(false, -1, 10)]
        [InlineData(true, 0, 0)]
        [InlineData(false, 5, 100)]
        [InlineData(true, 1, 6)]

        public void RandomLocation(bool boundary, int randomX, int randomZ)
        {
            Assert.Equal(boundary, _neighborWarsMethods.RandomLocation(randomX, randomZ));
        }

    }
}
