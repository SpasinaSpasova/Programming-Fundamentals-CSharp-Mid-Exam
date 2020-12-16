using System;

namespace _01._Easter_Cozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double priceFlour = double.Parse(Console.ReadLine());

            double priceEgs = (priceFlour * 75) / 100;
            double priceMilk = ((priceFlour * 0.25) + priceFlour)*0.250;
            double totalPrice = priceFlour + priceMilk + priceEgs;

            int coloredEgs = 0;
            int countCozunaks =0;

            while (budget> totalPrice)
            {
               
                budget -= totalPrice;
                countCozunaks++;
                coloredEgs += 3;
                if (countCozunaks%3==0)
                {
                    coloredEgs -=(countCozunaks - 2);
                }
            }
            Console.WriteLine($"You made {countCozunaks} cozonacs! Now you have {coloredEgs} eggs and {budget:f2}BGN left.");
        }
    }
}
