using ArenaGame.Enums;

namespace ArenaGame
{
    public abstract class Hero : IHero
    {
        protected Random random = new Random();
        public string Name { get; private set; }
        public double Health { get; private set; }
        public double Armor { get; private set; }
        public double Strenght { get; private set; }
        public IWeapon Weapon { get; private set; }
        public SpecialElement SpecialElement { get; private set; }

        public bool IsAlive
        {
            get
            {
                return this.Health > 0;
            }
        }

        public Hero(string name, double armor, double strenght, IWeapon weapon, Enums.SpecialElement specialElement)
        {
            this.Health = 100;

            this.Name = name;
            this.Armor = armor;
            this.Strenght = strenght;
            this.Weapon = weapon;
            this.SpecialElement = specialElement;
        }


        // returns actual damage
        public virtual double Attack()
        {
            double totalDamage = this.Strenght + this.Weapon.AttackDamage;
            double coef = this.random.Next(80, 120 + 1);
            double realDamage = totalDamage * (coef / 100);
            return realDamage;
        }

        public virtual double Defend(double damage, SpecialElement specialElement)
        {
            if (this.SpecialElement == specialElement)
                return this.Defend(damage * 2);

            return this.Defend(damage);
        }

        public virtual double Defend(double damage)
        {
            double coef = this.random.Next(80, 120 + 1);
            double defendPower = (this.Armor + this.Weapon.BlockingPower) * (coef / 100);
            double realDamage = damage - defendPower;
            if (realDamage < 0)
                realDamage = 0;
            this.Health -= realDamage;
            return realDamage;
        }

        public override string ToString()
        {
            return $"{this.Name} with health {Math.Round(this.Health, 2)}";
        }
    }
}
