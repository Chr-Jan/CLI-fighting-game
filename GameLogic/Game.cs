using CLI_fighting_game.InteractionLayer;
using CLI_fighting_game.ArgumentLayer;

namespace CLI_fighting_game.GameLogic
{
    public class Game
    {
        private Player player;
        private Enemy enemy;
        private UI ui;

        public Game(string playerOneName, string enemyName)
        {
            player = new Player(playerOneName);
            enemy = new Enemy(enemyName);
            ui = new UI();
        }

        public void StartGame()
        {
            bool gameOn = true;

            while (gameOn)
            {
                // Display player and enemy health
                ui.DisplayPlayerHealth(player.Name, player.Health);
                ui.DisplayPlayerHealth(enemy.Name, enemy.Health);

                // Get player one's action
                string playerOneAction = ui.GetPlayerAction(player.Name);
                PerformAction(player, enemy, playerOneAction);

                if (enemy.Health <= 0)
                {
                    ui.DisplayMessage($"{player.Name} wins!");
                    Console.ReadKey();
                    break;
                }

                // Enemy decides its action
                string enemyAction = enemy.DecideAction();
                ui.DisplayMessage($"{enemy.Name} chooses to {enemyAction}!");
                PerformAction(enemy, player, enemyAction);

                if (player.Health <= 0)
                {
                    ui.DisplayMessage($"{enemy.Name} wins!");
                    Console.ReadKey();
                    break;
                }
            }
        }

        private void PerformAction(ICharacter actor, ICharacter target, string action)
        {
            switch (action.ToLower())
            {
                case "attack":
                    if (actor is Player)
                    {
                        ui.DisplayMessage($"{actor.Name} attacks {target.Name}!");
                        int damage = ((Player)actor).PerformAttack(); // Get attack damage from Player
                        target.ReceiveDamage(damage); // Apply damage to the target
                    }
                    else if (actor is Enemy)
                    {
                        ui.DisplayMessage($"{actor.Name} attacks {target.Name}!");
                        int damage = ((Enemy)actor).PerformAttack(); // Get attack damage from Enemy
                        target.ReceiveDamage(damage); // Apply damage to the target
                    }
                    break;

                case "heal":
                    if (actor is Player)
                    {
                        ui.DisplayMessage($"{actor.Name} heals themselves!");
                        ((Player)actor).Heal();
                    }
                    else if (actor is Enemy)
                    {
                        ui.DisplayMessage($"{actor.Name} heals themselves!");
                        ((Enemy)actor).Heal();
                    }
                    break;

                case "defend":
                    ui.DisplayMessage($"{actor.Name} is defending!");
                    break;

                default:
                    ui.DisplayMessage("Invalid action. Try again.");
                    break;
            }
        }
    }
}
