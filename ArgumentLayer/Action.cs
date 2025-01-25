using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI_fighting_game.ArgumentLayer
{
    public class Action
    {
        private Random rnd;

        // Constructor to initialize Random once
        public Action()
        {
            rnd = new Random();
        }

        // Determine a successful action and return the success value
        internal int Success()
        {
            return rnd.Next(1, 100); // Return a success percentage between 1 and 100
        }

        // Attack logic: returns damage dealt to the opponent
        public int Attack()
        {
            // Determine if the attack is successful
            int successChance = Success();

            // If the success chance is greater than 80, it's a successful attack
            if (successChance < 80)
            {
                Console.WriteLine("Attack successful!");
                return rnd.Next(5, 20); // Random damage between 1 and 20
            }
            else
            {
                Console.WriteLine("Attack missed!");
                return 0; // Attack missed
            }
        }

        // Heal the player: returns amount healed
        public int Heal()
        {
            int successChance = Success();

            if(successChance < 50)
            {
                Console.WriteLine("Heal successful!");
                return rnd.Next(5, 15); // Random heal between 5 and 15
            }
            else
            {
                Console.WriteLine("Heal failed!");
                return 0; // Heal failed
            }
        }
    }
}
