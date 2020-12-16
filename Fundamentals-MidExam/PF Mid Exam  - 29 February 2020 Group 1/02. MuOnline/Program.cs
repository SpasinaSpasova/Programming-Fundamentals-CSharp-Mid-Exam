using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = 100;
            int bitcoins = 0;

            string[] rooms = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] tokens = rooms[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];
                int number = int.Parse(tokens[1]);

                if (command == "potion")
                {
                    if (initialHealth + number > 100)
                    {
                        int diff = 100 - initialHealth;
                        initialHealth += diff;
                        Console.WriteLine($"You healed for {diff} hp.");
                    }
                    else
                    {
                        initialHealth += number;
                        Console.WriteLine($"You healed for {number} hp.");

                    }
                    Console.WriteLine($"Current health: {initialHealth} hp.");
                }
                else if (command == "chest")
                {
                    bitcoins += number;
                    Console.WriteLine($"You found {number} bitcoins.");
                }
                else
                {
                    initialHealth -= number;
                    if (initialHealth > 0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        break;
                    }
                }
            }
            if (initialHealth > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {initialHealth}");
            }
        }
    }
}
