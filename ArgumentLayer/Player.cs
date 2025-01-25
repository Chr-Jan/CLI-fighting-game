namespace CLI_fighting_game.ArgumentLayer
{
    public class Player : ICharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        private Action PlayerAction { get; set; }

        public Player(string name)
        {
            Name = name;
            Health = 100;
            PlayerAction = new Action(); // Use Action for the mechanics
        }

        public void ReceiveDamage(int damage)
        {
            Health -= damage;
            Health = Math.Max(0, Health); // Prevent negative health
        }

        public int PerformAttack()
        {
            return PlayerAction.Attack(); // Generate attack damage
        }

        public void Heal()
        {
            int healAmount = PlayerAction.Heal(); // Heal using Action logic
            Health += healAmount;
        }
    }
}
