namespace ArenaGame.Heroes
{
    public class Assassin : Hero
    {
        public Assassin(string name, double armor, double strenght, IWeapon weapon, Enums.SpecialElement specialElement) :
            base(name, armor, strenght, weapon, specialElement)
        {
        }

        public override double Attack()
        {
            double damage = base.Attack();

            double probability = this.random.NextDouble();
            if (probability < 0.10)
            {
                damage *= 3;
            }
            return damage;
        }
    }
}
