using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {

        private const double coffeeMillileters = 50;
        private const decimal coffeePrice = 3.50m;


        public Coffee(string name, double caffeine) 
            : base(name, coffeePrice, coffeeMillileters)
        {
            this.Caffeine = caffeine;
        }

        public double Caffeine { get; set; }

    }
}
