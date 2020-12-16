using System;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;
            while (input != "special" && input != "regular")
            {
                double currentPriceWithoutTaxes = double.Parse(input);

                if (currentPriceWithoutTaxes > 0)
                {
                    sum += currentPriceWithoutTaxes;
                    input = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid price!");
                    input = Console.ReadLine();
                }
            }

            double taxes = sum * 0.2;
            double priceWithTaxes = sum + taxes;
            if (input == "special")
            {
                priceWithTaxes = priceWithTaxes * 0.9;
            }
            if (priceWithTaxes == 0 || priceWithTaxes < 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sum:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {priceWithTaxes:f2}$");

            }

        }
    }
}
