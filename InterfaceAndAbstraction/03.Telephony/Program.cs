using System;
using System.Linq;

namespace _03.Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            string[] numbersToDial = Console.ReadLine().Split(" ");
            string[] sitesToVisit = Console.ReadLine().Split(" ");


            ISmartphone smartphone = new Smartphone();
            IStationaryPhone statPhone = new StationaryPhone();


            foreach (var number in numbersToDial)
            {
                if (number.Length == 10)
                {
                    smartphone.Call(number);
                }
                else
                {
                    statPhone.Dial(number);
                }
            }

            foreach (var website in sitesToVisit)
            {
                smartphone.Browse(website);
            }


        }
    }
}
