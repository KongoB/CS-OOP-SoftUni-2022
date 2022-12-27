namespace Wild_Farm.Animal
{
    public abstract class Animal
    {

        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }


        public abstract string AskForFood();

        public abstract void Feed(Food.Food food);
    }
}
