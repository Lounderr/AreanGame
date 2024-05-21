namespace ArenaGame
{
    public interface IWeapon
    {
        string Name { get; set; }
        double AttackDamage { get; }
        double BlockingPower { get; }
    }
}
