namespace ArenaGame
{
    public class GameEngine
    {
        public class NotificationArgs
        {
            public Hero Attacker { get; set; }
            public Hero Defender { get; set; }
            public double Attack { get; set; }
            public double Damage { get; set; }
        }

        public delegate void GameNotifications(NotificationArgs args);

        private Random random = new Random();
        public Hero HeroA { get; set; }
        public Hero HeroB { get; set; }
        public Hero Winner { get; set; }
        public GameNotifications? NotificationsCallBack { get; set; }
        public void Fight()
        {
            Hero attacker;
            Hero defender;

            double probability = this.random.NextDouble();
            if (probability < 0.5)
            {
                attacker = this.HeroA;
                defender = this.HeroB;
            }
            else
            {
                attacker = this.HeroB;
                defender = this.HeroA;
            }

            while (attacker.IsAlive)
            {
                double attack = attacker.Attack();
                double actualDamage;

                if (attacker.Weapon is ISpecial)
                    actualDamage = defender.Defend(attack, ((ISpecial)attacker.Weapon).SpecialElement);
                else
                    actualDamage = defender.Defend(attack);

                if (this.NotificationsCallBack != null)
                {

                    this.NotificationsCallBack(new NotificationArgs()
                    {
                        Attacker = attacker,
                        Defender = defender,
                        Attack = attack,
                        Damage = actualDamage
                    });
                }

                Hero tempHero = attacker;
                attacker = defender;
                defender = tempHero;
            }
            this.Winner = defender;
        }
    }
}
