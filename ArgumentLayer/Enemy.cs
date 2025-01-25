using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI_fighting_game.ArgumentLayer
{
    public class Enemy : ICharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }

        private Action EnemyAction { get; set; }

        public Enemy(string name)
        {
            Name = name;
            Health = 100;
            EnemyAction = new Action(); // Use Action for the mechanics
        }

        public void ReceiveDamage(int damage)
        {
            Health -= damage;
            Health = Math.Max(0, Health); // Prevent negative health
        }

        public int PerformAttack()
        {
            return EnemyAction.Attack();
        }

        public void Heal()
        {
            int healAmount = EnemyAction.Heal(); // Heal using Action logic
            Health += healAmount;
        }
    }
}