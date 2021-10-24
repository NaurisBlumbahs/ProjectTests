using System;

namespace NeighborWarsProject
{
    public class NeighborWarsMethods
    {
        private static void Main()
        {
        }

        /// <summary>
        /// You play against the enemy neighbor. The time limit is set to 60 seconds.
        /// Each player starts with 10 items in their backyard. 
        /// You have to throw the items over the fence in to your neighbors yard.
        /// Once the item leaves your yard, your point count (player) is reduced.
        /// When the item lands in your enemies yard, the enemies point count (enemy) is increased.
        /// When time is over, the game enters a bool state of isGameOver.
        /// Once the games has entered isGameOver state:
        /// If you the player have more points than the enemie, you have lost;
        /// If you the player have less points than the enemie, you have won;
        /// If you the player have the same points as the enemie, then it is a draw;
        /// Return one of the 3 possible states as an string depending on the result.
        /// The states are: "Win", "Lose", "Draw".
        /// 
        /// gameStatus(5, 15, true) > "Win"
        /// gameStatus(15, 5, true) > "Lose"
        /// gameStatus(10, 10, true) > "Draw"
        /// </summary>

        public string GameStatus(int player, int enemy, bool isGameOver)
        {
            if (player < enemy && isGameOver)
                return "Win";

            if (player > enemy && isGameOver)
                return "Lose";

            if (player == enemy && isGameOver)
                return "Draw";

            return "";
        }

        /// <summary>
        /// Playing the game you will earn an ingame currency as coins.
        /// Depending on the game result you will receive a fixed amount of coins.
        /// From previous method GameStatus we know that there exists 3 different states.
        /// For a "Win" the player should receive 20 coins.
        /// For a "Lose" the player should receive 5 coins.
        /// For a "Draw" the player should receive 10 coins.
        /// Return the coin amount depending on the state of the game.
        /// 
        /// gameStatusReward("Win") > 20;
        /// gameStatusReward("Lose") > 5;
        /// gameStatusReward("Draw") > 10;
        /// </summary>

        public int GameStatusReward(string gameState)
        {
            int winAmount = 20;
            int loseAmount = 5;
            int drawAmount = 10;
            int sum = 0;

            if (gameState == "Win")
                return sum + winAmount;

            if (gameState == "Lose")
                return sum + loseAmount;

            if (gameState == "Draw")
                return sum + drawAmount;

            return sum;
        }

        /// <summary>
        /// Now that you have earned some coins there also must be a place where to spend these coins.
        /// The game has a shop, where you can buy different throwable items, houses and player skins.
        /// Each item can be purchased only 1 time and has a different cost. 
        /// Once the item is purchased a bool for that item will be become true, isPurchased.
        /// If the item isPurchased you can not buy it again.
        /// If you don't have enough coins, you can't also buy this item.
        /// Return true if you are able to purchase the item.
        /// 
        /// canBuyItem(100, 20, false) > true;
        /// canBuyItem(40, 40, false) > true;
        /// canBuyItem(5, 10, false) > false;
        /// </summary>

        public bool CanBuyItem(int coins, int cost, bool isPurchased)
        {
            if (coins >= cost && !isPurchased)
                return true;

            return false;
        }

        /// <summary>
        /// The game has 7 different levels. Each time you start a new round the level will be sellected randomly. 
        /// Each level has it's own unique name. 
        /// Return a string for the name of the level based of the levels number.
        /// The names of the levels based of the numbers:
        /// 0 = "Suburbs";
        /// 1 = "Trailer Park";
        /// 2 = "Egypt";
        /// 3 = "Forest";
        /// 4 = "Snow";
        /// 5 = "Island";
        /// 
        /// randomLevel(0) > "Suburbs";
        /// randomLevel(1) > "Trailer Park";
        /// randomLevel(2) > "Egypt";
        /// </summary>

        public string RandomLevel(int random)
        {
            if (random == 0)
                return "Suburbs";

            if (random == 1)
                return "Trailer Park";

            if (random == 2)
                return "Egypt";

            if (random == 3)
                return "Forest";

            if (random == 4)
                return "Snow";

            if (random == 5)
                return "Island";

            return "";
        }

        /// <summary>
        /// The items each round are generated in random positions in an given boundary for x and z positions.
        /// The minimal boundares are 0 and maximum are 10. Each item will be spawned in random locations in this given boundary.
        /// Return true if the boundaries are within limits and the item can be spawned.
        /// 
        /// randomLocation(0, 10) > true;
        /// randomLocation(-1, 10) > false;
        /// randomLocation(0, 0) > true;
        /// </summary>

        public bool RandomLocation(int randomX, int randomZ)
        {
            int min = 0;
            int max = 10;

            if (randomX >= min && randomX <= max && randomZ >= min && randomZ <= max)
            return true;

            return false;
        }


    }
}
