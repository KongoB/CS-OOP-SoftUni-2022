using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Dessert : Food
    {

        public Dessert(string name, decimal price, double grams, double callories) 
            : base (name, price, grams)
        {
            Callories = callories;
        }

        public double Callories { get; set; }

    }
}
