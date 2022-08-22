using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony
{
    public interface IStationaryPhone
    {

        public void Dial(string number)
        {
            if (int.TryParse(number, out _))
            {
                Console.WriteLine($"Dialing... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }

            
        }

    }
}
