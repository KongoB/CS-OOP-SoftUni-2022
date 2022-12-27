using System;

namespace Raiding.Heroes
{
    public class Warrior : BaseHero
    {

        private const int _warriorPower = 100;

        public Warrior(string name) : base(name)
        {
            Power = _warriorPower;
        }

        public override string CastAbility()
        {
            return $"Warrior - {this.Name} hit for {Power} damage";
        }
    }
}
