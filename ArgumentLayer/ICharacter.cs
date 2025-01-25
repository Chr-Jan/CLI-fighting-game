using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CLI_fighting_game.ArgumentLayer
{
    public interface ICharacter
    {
        string Name { get; set; }
        int Health { get; set; }

        // Define behaviors
        void ReceiveDamage(int damage);
        int PerformAttack(); // Could return damage dealt
        void Heal();
    }
}