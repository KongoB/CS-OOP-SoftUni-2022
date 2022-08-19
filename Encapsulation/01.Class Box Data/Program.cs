using System;

namespace P01.ClassBoxData
{

    public class StartUp
    {
        static void Main(string[] args)
        {

            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());


            Box box = null;


            try
            {
                box = new Box(lenght, width, height);
            }
            catch (ArgumentException a)
            {
                Console.WriteLine(a.Message);
            }


            Console.WriteLine(box);

        }
    }


}