using System;

namespace Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {

            string[] carStats = Console.ReadLine().Split();
            string[] truckStats = Console.ReadLine().Split();
            string[] busStats = Console.ReadLine().Split();


            Car car = new Car(double.Parse(carStats[1]), double.Parse(carStats[2]), double.Parse(carStats[3]));
            Truck truck = new Truck(double.Parse(truckStats[1]), double.Parse(truckStats[2]), double.Parse(truckStats[3]));
            Bus bus = new Bus(double.Parse(busStats[1]), double.Parse(busStats[2]), double.Parse(busStats[3]));


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
                    else if (command[1] == "Bus")
                    {
                        Console.WriteLine(bus.Drive(commandValue));
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
                    else if (command[1] == "Bus")
                    {
                        bus.Refuel(commandValue);
                    }
                }
                if (command[0] == "DriveEmpty")
                {
                    Console.WriteLine(bus.Drive(commandValue));
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);


        }
    }
}
