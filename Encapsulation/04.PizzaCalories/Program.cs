using System;

namespace _04.PizzaCalories
{

    public class StartUp
    {
        static void Main(string[] args)
        {

            
            while (true)
            {
                string[] input = Console.ReadLine().Split();


                if (input[0] == "END")
                {
                    break;
                }


                if (input[0] == "Dough")
                {
                    var dough = new Dough(input[1], input[2], double.Parse(input[3]));
                }







            }




            



            Console.WriteLine(dough.CalculateCalories());


        }
    }


}