using System;
using CLI_fighting_game.GameLogic;

namespace CLI_fighting_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the CLI Fighting Game!");
            Console.Write("Enter Player 1's name: ");
            string playerOneName = Console.ReadLine();
            Console.Write("Enter Player 2's name: ");
            string playerTwoName = Console.ReadLine();

            Game game = new Game(playerOneName, playerTwoName);
            game.StartGame();
        }
    }
}
