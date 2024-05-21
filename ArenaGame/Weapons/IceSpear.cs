using ArenaGame.Enums;

namespace ArenaGame.Weapons
{
    public class IceSpear : IWeapon, ISpecial
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public SpecialElement SpecialElement { get; private set; }

        public IceSpear(string name)
        {
            this.Name = name;
            this.AttackDamage = 20;
            this.BlockingPower = 10;

            this.SpecialElement = SpecialElement.Ice;
        }
    }
}
