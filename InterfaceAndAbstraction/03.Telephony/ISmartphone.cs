using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony
{
    public interface ISmartphone
    {

        public void Call(string number)
        {
            if (int.TryParse(number, out _))
            {
                Console.WriteLine($"Calling... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
            
        }

        public void Browse(string website)
        {
            bool valid = true;


            for (int i = 0; i < website.Length; i++)
            {

                if (int.TryParse(website[i].ToString(), out _))
                {
                    valid = false;
                }
            }

            if (valid)
            {
                Console.WriteLine($"Browsing: {website}!");
            }
            else
            {
                Console.WriteLine("Invalid URL!");
            }



        }



    }
}
