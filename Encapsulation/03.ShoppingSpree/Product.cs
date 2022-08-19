using System;

namespace _03.ShoppingSpree
{
    public class Product
    {

        private string _name;
        private decimal _cost;


        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }


        public string Name
        {
            get 
            { 
                return _name; 

            }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this._name = value;
            }
        }

        public decimal Cost 
        {
            get 
            {
                return _cost;
            }
            private set 
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("Money cannot be negative");
                }

                this._cost = value;
            } 
        }



    }
}
