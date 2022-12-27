using System;

namespace Raiding.Heroes
{
    public class Rogue : BaseHero
    {

        private const int _roguePower = 80;

        public Rogue(string name) : base(name)
        {
            Power = _roguePower;
        }

        public override string CastAbility()
        {
            return $"Rogue - {this.Name} hit for {Power} damage";
        }
    }
}
