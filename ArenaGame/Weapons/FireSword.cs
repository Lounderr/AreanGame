using ArenaGame.Enums;

namespace ArenaGame.Weapons
{
    public class MagicAxe : IWeapon, ISpecial
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public SpecialElement SpecialElement { get; private set; }

        public MagicAxe(string name)
        {
            this.Name = name;
            this.AttackDamage = 33;
            this.BlockingPower = 3;

            this.SpecialElement = SpecialElement.Magic;
        }
    }
}
