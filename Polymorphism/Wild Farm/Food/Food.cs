﻿namespace Wild_Farm.Food
{
    public abstract class Food
    {

        public Food(int quantity)
        {
            Quantity = quantity;
        }
        public int Quantity { get; set; }

    }
}
