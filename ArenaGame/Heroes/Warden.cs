namespace ArenaGame.Heroes
{
    public class Warden : Hero
    {
        private int shieldDurability;
        public Warden(string name, double armor, double strenght, IWeapon weapon, Enums.SpecialElement specialElement, int shieldDurability) : base(name, armor, strenght, weapon, specialElement)
        {
            this.shieldDurability = shieldDurability;
        }


        public override double Defend(double damage)
        {
            if (this.shieldDurability > 0)
            {
                this.shieldDurability--;
                return 0;
            }

            return base.Defend(damage);
        }
    }
}
