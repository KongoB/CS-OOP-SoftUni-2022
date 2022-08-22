using System;
using System.Collections.Generic;

namespace BorderControl
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Entities> entities = new List<Entities>();

            List<string> detainedIds = new List<string>();

            string wantedId;

            while (true)
            {

                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] currentEntity = input.Split(' ');

                if (currentEntity.Length == 3)
                {
                    string name = currentEntity[0];
                    int age = int.Parse(currentEntity[1]);
                    string id = currentEntity[2];


                    entities.Add(new Citizen(name, age, id));
                }

                else if (currentEntity.Length == 2)
                {
                    string name = currentEntity[0];
                    string id = currentEntity[1];

                    entities.Add(new Robot(name, id));
                }
            }

            wantedId = Console.ReadLine();


            foreach (var entity in entities)
            {

                if (entity.Id.EndsWith(wantedId))
                {
                    detainedIds.Add(entity.Id);
                }

            }

            foreach (var Id in detainedIds)
            {
                Console.WriteLine(Id);
            }


        }
    }
}
