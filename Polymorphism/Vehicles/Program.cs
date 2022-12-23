using System;

namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] carStats = Console.ReadLine().Split();
            string[] truckStats = Console.ReadLine().Split();


            Car car = new Car(double.Parse(carStats[1]), double.Parse(carStats[2]));
            Truck truck = new Truck(double.Parse(truckStats[1]), double.Parse(truckStats[2]));



            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                double commandValue = double.Parse(command[2]);


                if (command[0] == "Drive")
                {
                    if (command[1] == "Car")
                    {
                        Console.WriteLine(car.Drive(commandValue));
                    }
                    else if (command[1] == "Truck")
                    {
                        Console.WriteLine(truck.Drive(commandValue));
                    }
                }
                else if (command[0] == "Refuel")
                {
                    if (command[1] == "Car")
                    {
                        car.Refuel(commandValue);
                    }
                    else if (command[1] == "Truck")
                    {
                        truck.Refuel(commandValue);
                    }
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);


        }
    }
}
