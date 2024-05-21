namespace ArenaGame.Weapons
{
    public class Sword : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public Sword(string name)
        {
            this.Name = name;
            this.AttackDamage = 20;
            this.BlockingPower = 10;
        }
    }
}
