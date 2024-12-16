namespace CLI_fighting_game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            string playerOneName = "Player One";
            string playerTwoName = "Player Two";

            int playerOneHealth = 100;
            int playerTwoHealth = 100;

            while (playerOneHealth > 0 && playerTwoHealth > 0)
            {

                Random rnd = new Random();

                int attack = new Random().Next(1, 10);

                // Perform attack and adjust player health.
                int damage = attack;

                playerTwoHealth -= damage;

                Console.WriteLine($"{playerOneName} attacks Player Two for {damage} damage!");
                Console.WriteLine($"{playerTwoName} health is now {playerTwoHealth}.");

                Console.ReadKey();
            }

            if (playerTwoHealth > 0)
            {
                Console.WriteLine($"{playerTwoName} win!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"{playerOneName} win!");
                Console.ReadKey();
            }
        }
    }
}