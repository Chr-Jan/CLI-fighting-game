using System;
using CLI_fighting_game.GameLogic;

namespace CLI_fighting_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the CLI Fighting Game!");
            Console.Write("Enter Players name: ");
            string playerName = Console.ReadLine();
            string enemyName = "Goblin";

            Game game = new Game(playerName, enemyName);
            game.StartGame();
        }
    }
}
