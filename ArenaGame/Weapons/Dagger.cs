namespace ArenaGame.Weapons
{
    public class Dagger : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public Dagger(string name)
        {
            this.Name = name;
            this.AttackDamage = 30;
            this.BlockingPower = 1;
        }
    }
}
