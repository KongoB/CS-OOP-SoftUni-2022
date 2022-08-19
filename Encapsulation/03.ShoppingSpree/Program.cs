using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();


            string input = Console.ReadLine();

            string[] peopleSplit = input.Split(";", StringSplitOptions.RemoveEmptyEntries);

            try
            {
                foreach (string person in peopleSplit)
                {
                    string[] personMoney = person.Split("=", StringSplitOptions.RemoveEmptyEntries);

                    people.Add(new Person(personMoney[0], decimal.Parse(personMoney[1])));

                }

                input = Console.ReadLine();

                string[] productSplit = input.Split(";", StringSplitOptions.RemoveEmptyEntries);

                foreach (string product in productSplit)
                {
                    string[] productCost = product.Split("=", StringSplitOptions.RemoveEmptyEntries);

                    products.Add(new Product(productCost[0], decimal.Parse(productCost[1])));

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }

            while (true)
            {

                input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] inputSplit = input.Split(" ");


                foreach (var person in people)
                {
                    if (person.Name == inputSplit[0])
                    {

                        var selectedProduct = products.Where(x => x.Name == inputSplit[1]).FirstOrDefault();

                        if (person.Money < selectedProduct.Cost)
                        {
                            Console.WriteLine($"{person.Name} can't afford {selectedProduct.Name}");
                        }
                        else
                        {
                            person.Buy(selectedProduct);


                            Console.WriteLine($"{person.Name} bought {selectedProduct.Name}");
                        }

                    }
                }

            }


            foreach (var person in people)
            {

                if (person.BagOfProducts.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - " + String.Join(", ", person.BagOfProducts.Select(x => x.Name)) );
                }



            }




        }
    }
}