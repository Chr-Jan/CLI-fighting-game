using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI_fighting_game.ArgumentLayer
{
    public class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public Action PlayerAction { get; set; }  // Action instance to perform actions on this player

        public Player(string name)
        {
            Name = name;
            Health = 100; // Default health
            PlayerAction = new Action();  // Initialize the action instance
        }

        // Apply damage to the player
        public void ReceiveDamage(int damage)
        {
            Health -= damage;
            Health = Math.Max(0, Health); // Prevent health from going negative
        }

        // Heal the player
        public void Heal()
        {
            int healAmount = PlayerAction.Heal();  // Using the Action class to heal
            Health += healAmount;
        }

        // Perform an attack on another player
        public void Attack(Player opponent)
        {
            int damage = PlayerAction.Attack();  // Using the Action class to attack
            opponent.ReceiveDamage(damage);  // Apply damage to the opponent
        }
    }
}
