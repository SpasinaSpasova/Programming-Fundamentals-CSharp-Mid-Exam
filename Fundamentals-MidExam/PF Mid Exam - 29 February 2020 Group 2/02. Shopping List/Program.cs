using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()
                 .Split("!", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = tokens[0];
                string item = tokens[1];

                if (command == "Urgent")
                {
                    if (!groceries.Contains(item))
                    {
                        groceries.Insert(0, item);
                    }
                }
                else if (command == "Unnecessary")
                {
                    groceries.Remove(item);
                }
                else if (command == "Correct")
                {
                    if (groceries.Contains(item))
                    {
                        string newItem = tokens[2];

                        int indexOfOldItem = groceries.IndexOf(item);
                        groceries.Remove(item);
                        groceries.Insert(indexOfOldItem, newItem);
                    }
                }
                else if (command == "Rearrange")
                {
                    if (groceries.Contains(item))
                    {
                        groceries.Remove(item);
                        groceries.Add(item);
                    }
                }


                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",groceries));
        }
    }
}
