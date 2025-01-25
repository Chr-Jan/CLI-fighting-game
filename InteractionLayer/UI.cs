namespace CLI_fighting_game.InteractionLayer
{
    public class UI
    {
        // Display a message to the player
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        // Prompt the user to choose an action and return their input
        public string GetPlayerAction(string playerName)
        {
            Console.WriteLine($"{playerName}: choose your action (Attack / Defend / Heal): ");
            return Console.ReadLine().Trim();
        }

        // Display the player's current health
        public void DisplayPlayerHealth(string playerName, int health)
        {
            Console.WriteLine($"{playerName}'s health is now {Math.Max(0, health)}.");
        }
    }
}
