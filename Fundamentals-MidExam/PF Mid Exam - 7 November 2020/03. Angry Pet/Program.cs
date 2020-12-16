using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Angry_Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> priceRatings = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int entryPoint = int.Parse(Console.ReadLine());
            string typeOfItems = Console.ReadLine();
            string typeOfPrice = Console.ReadLine();

            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < entryPoint; i++)
            {
                if (typeOfItems == "cheap")
                {
                    if (typeOfPrice == "positive")
                    {

                        if (priceRatings[i] < priceRatings[entryPoint] && priceRatings[i] > 0)
                        {
                            sumLeft += priceRatings[i];
                        }
                    }
                    else if (typeOfPrice == "negative")
                    {

                        if (priceRatings[i] < priceRatings[entryPoint] && priceRatings[i] <= 0)
                        {
                            sumLeft += priceRatings[i];
                        }

                    }
                    else if (typeOfPrice == "all")
                    {

                        if (priceRatings[i] < priceRatings[entryPoint])
                        {
                            sumLeft += priceRatings[i];
                        }

                    }
                }
                else if (typeOfItems == "expensive")
                {
                    if (typeOfPrice == "positive")
                    {

                        if (priceRatings[i] >= priceRatings[entryPoint] && priceRatings[i] > 0)
                        {
                            sumLeft += priceRatings[i];
                        }
                    }
                    else if (typeOfPrice == "negative")
                    {

                        if (priceRatings[i] >= priceRatings[entryPoint] && priceRatings[i] <= 0)
                        {
                            sumLeft += priceRatings[i];
                        }

                    }
                    else if (typeOfPrice == "all")
                    {

                        if (priceRatings[i] >= priceRatings[entryPoint])
                        {
                            sumLeft += priceRatings[i];
                        }

                    }
                }
            }
            for (int i = entryPoint + 1; i < priceRatings.Count; i++)
            {
                if (typeOfItems == "cheap")
                {
                    if (typeOfPrice == "positive")
                    {

                        if (priceRatings[i] < priceRatings[entryPoint] && priceRatings[i] > 0)
                        {
                            sumRight += priceRatings[i];
                        }
                    }
                    else if (typeOfPrice == "negative")
                    {

                        if (priceRatings[i] < priceRatings[entryPoint] && priceRatings[i] <= 0)
                        {
                            sumRight += priceRatings[i];
                        }

                    }
                    else if (typeOfPrice == "all")
                    {

                        if (priceRatings[i] <= priceRatings[entryPoint])
                        {
                            sumRight += priceRatings[i];
                        }

                    }
                }
                else if (typeOfItems == "expensive")
                {
                    if (typeOfPrice == "positive")
                    {

                        if (priceRatings[i] >= priceRatings[entryPoint] && priceRatings[i] > 0)
                        {
                            sumRight += priceRatings[i];
                        }
                    }
                    else if (typeOfPrice == "negative")
                    {

                        if (priceRatings[i] >= priceRatings[entryPoint] && priceRatings[i] <= 0)
                        {
                            sumRight += priceRatings[i];
                        }

                    }
                    else if (typeOfPrice == "all")
                    {

                        if (priceRatings[i] >= priceRatings[entryPoint])
                        {
                            sumRight += priceRatings[i];
                        }

                    }
                }
            }
            if (sumLeft > sumRight)
            {
                Console.WriteLine($"Left - {sumLeft}");
            }
            else if (sumLeft < sumRight)
            {
                Console.WriteLine($"Right - {sumRight}");

            }
            else
            {
                Console.WriteLine($"Left - {sumLeft}");

            }
        }
    }
}
