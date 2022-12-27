namespace Wild_Farm.Animal
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override string AskForFood()
        {
            return "Squeak";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }

        public override void Feed(Food.Food food)
        {

            string foodType = food.GetType().Name;

            if (foodType == "Vegetable" || foodType == "Fruit")
            {
                this.Weight += food.Quantity * 0.10;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {foodType}!");
            }
            
        }


    }
}
