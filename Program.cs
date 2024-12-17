using System;

namespace CLI_fighting_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the CLI Fighting Game!");

            string playerOneName = "Player One";
            string playerTwoName = "Player Two";

            int playerOneHealth = 100;
            int playerTwoHealth = 100;

            Random rnd = new Random(); // Create a single instance of Random

            while (playerOneHealth > 0 && playerTwoHealth > 0)
            {
                // Player One attacks Player Two
                int damage = rnd.Next(1, 10);
                playerTwoHealth -= damage;

                Console.WriteLine($"{playerOneName} attacks {playerTwoName} for {damage} damage!");
                Console.WriteLine($"{playerTwoName}'s health is now {Math.Max(0, playerTwoHealth)}."); // Prevent negative health display

                // Check if both players' health reaches 0
                if (playerTwoHealth <= 0 && playerOneHealth <= 0)
                {
                    Console.WriteLine($"It's a draw! Both {playerOneName} and {playerTwoName} have fallen.");
                    break;
                }

                // Check if Player Two is defeated
                if (playerTwoHealth <= 0)
                {
                    Console.WriteLine($"{playerOneName} wins!");
                    break;
                }

                Console.ReadKey();

                // Player Two attacks Player One
                int damage2 = rnd.Next(1, 10);
                playerOneHealth -= damage2;

                Console.WriteLine($"{playerTwoName} attacks {playerOneName} for {damage2} damage!");
                Console.WriteLine($"{playerOneName}'s health is now {Math.Max(0, playerOneHealth)}.");

                // Check if both players' health reaches 0
                if (playerTwoHealth <= 0 && playerOneHealth <= 0)
                {
                    Console.WriteLine($"It's a draw! Both {playerOneName} and {playerTwoName} have fallen.");
                    break;
                }

                // Check if Player One is defeated
                if (playerOneHealth <= 0)
                {
                    Console.WriteLine($"{playerTwoName} wins!");
                    break;
                }

                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
