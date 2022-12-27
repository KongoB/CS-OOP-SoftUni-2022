using System;

namespace Raiding.Heroes
{
    public class Paladin : BaseHero
    {

        private const int _paladinPower = 100;

        public Paladin(string name) : base(name)
        {
            Power = _paladinPower;
        }


        public override string CastAbility()
        {
            return $"Paladin - {this.Name} healed for {Power}";
        }
    }
}
