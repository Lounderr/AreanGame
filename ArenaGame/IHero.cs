using ArenaGame.Enums;

namespace ArenaGame
{
    public interface IHero
    {
        public SpecialElement SpecialElement { get; }
        double Attack();
        double Defend(double damage);
    }
}
