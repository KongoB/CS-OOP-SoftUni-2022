
namespace BirthdayCelebrations
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {

            List<Entities> entities = new List<Entities>();


            while (true)
            {

                string[] input = Console.ReadLine().Split(' ');



                if (input[0] == "End") break;


                if (input[0] == "Citizen")
                {

                    string name = input[1];
                    int age = int.Parse(input[2]);
                    string id = input[3];
                    string birthdate = input[4];

                    entities.Add(new Citizen(name, age, id, birthdate));
                }

                else if (input[0] == "Robot")
                {
                    string name = input[1];
                    string id = input[2];

                    entities.Add(new Robot(name, id));

                }

                else if (input[0] == "Pet")
                {

                    string name = input[1];
                    string birthdate = input[2];

                    entities.Add(new Pet(name, birthdate));
                }

            }

            string lookForBirthdate = Console.ReadLine();


            foreach (Entities entity in entities)
            {

                if (entity.GetType() != typeof(Robot))
                {
                    string[] currentBirthdate = entity.Birthdate.Split('/');

                    if (currentBirthdate[2] == lookForBirthdate)
                    {
                        Console.WriteLine(entity.Birthdate);
                    }
                }

            }

        }
    }
}
