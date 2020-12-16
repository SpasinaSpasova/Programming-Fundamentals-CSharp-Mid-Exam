using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Easter_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shops = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int numOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCommands; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = tokens[0];

                if (command == "Include")
                {
                    string current = tokens[1];
                    if (!shops.Contains(current))
                    {

                        shops.Add(current);
                    }
                }
                else if (command == "Visit")
                {
                    int numberOfShops = int.Parse(tokens[2]);
                    if (numberOfShops > shops.Count)
                    {
                        continue;
                    }
                    if (tokens[1] == "first")
                    {
                        shops.RemoveRange(0, numberOfShops);
                    }
                    else if (tokens[1] == "last")
                    {
                        shops.RemoveRange((shops.Count-1)-numberOfShops+1, numberOfShops);


                    }
                }
                else if (command == "Prefer")
                {
                    int firstIndex = int.Parse(tokens[1]);
                    int secondIndex = int.Parse(tokens[2]);

                    if ((firstIndex >= 0 && firstIndex < shops.Count)
                        &&( secondIndex >= 0 && secondIndex < shops.Count))
                    {
                        string temp = shops[firstIndex];
                        shops[firstIndex] = shops[secondIndex];
                        shops[secondIndex] = temp;

                       
                    }

                }
                else if (command == "Place")
                {
                    int index = int.Parse(tokens[2]);
                    string currentShop = tokens[1];

                    if (index+1 >= 0 && index+1 < shops.Count)
                    {
                        shops.Insert(index+1, currentShop);
                    }
                }
            }
            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ", shops));
        }
    }
}
