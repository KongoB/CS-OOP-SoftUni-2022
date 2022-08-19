using System;
using System.Collections.Generic;

namespace _03.ShoppingSpree
{
    public class Person
    {

        private string _name;
        private decimal _money;
        private List<Product> _bagOfProducts;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;

            _bagOfProducts = new List<Product>();
        }

        public string Name 
        {
            get
            {
                return _name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                _name = value;
            } 
        }

        public decimal Money 
        {
            get
            {
                return _money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("Money cannot be negative");
                }

                _money = value;
            }
        }


        public IReadOnlyCollection<Product> BagOfProducts 
        {
            get
            {
                return this._bagOfProducts;
            } 
        }




        public void Buy (Product product)
        {
            Money -= product.Cost;
            _bagOfProducts.Add(product);
        }

    }
}
