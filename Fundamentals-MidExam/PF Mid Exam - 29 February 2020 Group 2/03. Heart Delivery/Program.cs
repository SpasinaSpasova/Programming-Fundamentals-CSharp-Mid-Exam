using System;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhoods = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();

            int jumpIndex = 0;

            while (input != "Love!")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int jumpLenght = int.Parse(tokens[1]);

                jumpIndex += jumpLenght;

                if (jumpIndex >= 0 && jumpIndex < neighborhoods.Length)
                {
                    neighborhoods[jumpIndex] -= 2;
                }
                else
                {
                    jumpIndex = 0;
                    neighborhoods[jumpIndex] -= 2;

                }

                if (neighborhoods[jumpIndex] == 0)
                {
                    Console.WriteLine($"Place {jumpIndex} has Valentine's day.");
                }
                else if (neighborhoods[jumpIndex] < 0)
                {
                    Console.WriteLine($"Place {jumpIndex} already had Valentine's day.");
                }



                input = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {jumpIndex}.");
            int faildCount = neighborhoods.Count(x => x > 0);

            if (faildCount == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {

                Console.WriteLine($"Cupid has failed {faildCount} places.");
            }
        }
    }
}
