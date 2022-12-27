using System;

namespace Raiding.Heroes
{
    public class Druid : BaseHero
    {

        private const int _druidPower = 80;


        public Druid(string name) : base(name)
        {
            Power = _druidPower;

        }



        public override string CastAbility()
        {

            return $"Druid - {this.Name} - healed for {this.Power}";


        }
    }
}
