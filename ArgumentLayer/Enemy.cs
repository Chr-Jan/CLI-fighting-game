using System;

namespace CLI_fighting_game.ArgumentLayer
{
    public class Enemy : ICharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }

        private Action EnemyAction { get; set; }
        private Random rnd;

        public Enemy(string name)
        {
            Name = name;
            Health = 100;
            EnemyAction = new Action();
            rnd = new Random();
        }

        // Enemy receives damage
        public void ReceiveDamage(int damage)
        {
            Health -= damage;
            Health = Math.Max(0, Health); // Prevent negative health
        }

        // Enemy performs an attack
        public int PerformAttack()
        {
            return EnemyAction.Attack();
        }

        // Enemy heals itself
        public void Heal()
        {
            int healAmount = EnemyAction.Heal();
            Health += healAmount;
            Console.WriteLine($"{Name} heals for {healAmount} health!");
        }

        // Decide what action the enemy will take
        public string DecideAction()
        {
            if (Health < 30) // If health is low, prioritize healing
            {
                return rnd.Next(0, 100) > 50 ? "heal" : "attack";
            }
            else
            {
                return "attack"; // Otherwise, focus on attacking
            }
        }
    }
}
