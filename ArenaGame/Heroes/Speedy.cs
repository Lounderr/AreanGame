namespace ArenaGame.Heroes
{
    public class Speedy : Hero
    {
        public Speedy(string name, double armor, double strenght, IWeapon weapon, Enums.SpecialElement specialElement) :
            base(name, armor, strenght, weapon, specialElement)
        {
        }

        public override double Attack()
        {
            double damage = base.Attack();

            if (this.random.Next(0, 5) == 1)
                damage += base.Attack() * 2;

            return damage;
        }
    }
}
