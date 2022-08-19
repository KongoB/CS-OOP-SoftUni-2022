using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            var animals = new List<Animal>();


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Beast!")
                {
                    break;
                }

                string[] input2 = Console.ReadLine().Split();

                try
                {
                    string name = input2[0];
                    int age = int.Parse(input2[1]);
                    string gender = input2[2];
                        
                }
                catch (Exception)
                {

                    throw new Exception("Invalid input!");
                }



                if (input == "Dog")
                {
                    animals.Add(new Dog(input2[0], int.Parse(input2[1]), input2[2]));
                }
                else if (input == "Frog")
                {
                    animals.Add(new Frog(input2[0], int.Parse(input2[1]), input2[2]));
                }
                else if (input == "Cat")
                {
                    if (input == "Kitten" && input2[2] == "Female")
                    {
                        animals.Add(new Kitten(input2[0], int.Parse(input2[1]), input2[2]));
                    }
                    else if (input == "Tomcat" && input2[2] == "Male")
                    {
                        animals.Add(new Tomcat(input2[0], int.Parse(input2[1]), input2[2]));
                    }
                    else
                    {
                        animals.Add(new Cat(input2[0], int.Parse(input2[1]), input2[2]));
                    }
                }


            }



            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }

        }
    }
}
