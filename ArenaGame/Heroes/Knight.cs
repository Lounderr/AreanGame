namespace ArenaGame.Heroes
{
    public class Knight : Hero
    {
        private double hitCount;
        private double damageCoef;
        public Knight(string name, double armor, double strenght, IWeapon weapon, Enums.SpecialElement specialElement) : base(name, armor, strenght, weapon, specialElement)
        {
            this.hitCount = 0;
            this.damageCoef = 0.6;
        }

        public override double Attack()
        {
            double damage = base.Attack();
            double realDamage = damage * this.damageCoef;
            if (this.damageCoef < 1) this.damageCoef += 0.1;
            return realDamage;
        }

        public override double Defend(double damage)
        {
            this.hitCount++;
            if (this.hitCount == 3)
            {
                this.hitCount = 0;
                return 0;
            }
            return base.Defend(damage);
        }
    }
}
