using CLI_fighting_game.InteractionLayer;
using CLI_fighting_game.ArgumentLayer;

namespace CLI_fighting_game.GameLogic
{
    public class Game
    {
        private Player playerOne;
        private Player playerTwo;
        private UI ui;

        public Game(string playerOneName, string playerTwoName)
        {
            playerOne = new Player(playerOneName);
            playerTwo = new Player(playerTwoName);
            ui = new UI();
        }

        public void StartGame()
        {
            bool gameOn = true;
            while (gameOn)
            {
                // Display player health
                ui.DisplayPlayerHealth(playerOne.Name, playerOne.Health);
                ui.DisplayPlayerHealth(playerTwo.Name, playerTwo.Health);

                // Get player one action
                string playerOneAction = ui.GetPlayerAction(playerOne.Name);
                PerformAction(playerOne, playerTwo, playerOneAction);

                if (playerTwo.Health <= 0)
                {
                    ui.DisplayMessage($"{playerOne.Name} wins!");
                    break;
                }

                // Get player two action
                string playerTwoAction = ui.GetPlayerAction(playerTwo.Name);
                PerformAction(playerTwo, playerOne, playerTwoAction);

                if (playerOne.Health <= 0)
                {
                    ui.DisplayMessage($"{playerTwo.Name} wins!");
                    break;
                }
            }
        }

        private void PerformAction(Player player, Player opponent, string action)
        {
            switch (action.ToLower())
            {
                case "attack":
                    player.Attack(opponent);
                    break;
                case "heal":
                    player.Heal();
                    break;
                case "defend":
                    ui.DisplayMessage($"{player.Name} is defending!");
                    break;
                default:
                    ui.DisplayMessage("Invalid action. Try again.");
                    break;
            }
        }
    }
}
