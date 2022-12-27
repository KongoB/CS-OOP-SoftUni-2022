using Wild_Farm.Animal;
using Wild_Farm.Food;


List<Animal> animals = new List<Animal>();


while (true)
{
	string[] input = Console.ReadLine().Split();

	Animal animal = null;
    Food food = null;

	if (input[0] == "End")
	{
		break;
	}

	string animalType = input[0];
	string animalName = input[1];
    double animalWeight = double.Parse(input[2]);

    if (animalType == "Hen" || animalType == "Owl")
	{
		double wingSize = double.Parse(input[3]);

		if (animalType == "Hen")
		{
			animal = new Hen(animalName, animalWeight, wingSize);
        }
		if (animalType == "Owl")
		{
            animal = new Owl(animalName, animalWeight, wingSize);
        }
	}
	else
	{
        string livingRegion = input[3];

        if (animalType == "Mouse")
        {
            animal = new Mouse(animalName, animalWeight, livingRegion);
        }
        if (animalType == "Dog")
        {
            animal = new Dog(animalName, animalWeight, livingRegion);
        }

        if (animalType == "Cat" || animalType == "Tiger")
        {
            string breed = input[4];

            if (animalType == "Cat")
            {
                animal = new Cat(animalName, animalWeight, livingRegion, breed);
            }
            if (animalType == "Tiger")
            {
                animal = new Tiger(animalName, animalWeight, livingRegion, breed);
            }
        }
    }

    string[] foodInfo = Console.ReadLine().Split();
    string foodName = foodInfo[0];
    int foodQuantity = int.Parse(foodInfo[1]);

    switch (foodName)
    {
        case "Vegetable":
            food = new Vegetable(foodQuantity);
            break;
        case "Fruit":
            food = new Fruit(foodQuantity);
            break;
        case "Meat":
            food = new Meat(foodQuantity);
            break;
        case "Seeds":
            food = new Seeds(foodQuantity);
            break;
        default:
            break;
    }

    Console.WriteLine(animal.AskForFood());
    animal.Feed(food);

    animals.Add(animal);
}


foreach (var animal in animals)
{
    Console.WriteLine(animal);
}