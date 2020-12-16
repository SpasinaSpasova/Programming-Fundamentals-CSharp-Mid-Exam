using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            while (input != "Craft!")
            {
                string[] tokens = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = tokens[0];
                string item = tokens[1];

                if (command== "Collect")
                {
                    if (!journal.Contains(item))
                    {
                        journal.Add(item);
                    }
                }
                else if (command== "Drop")
                {
                    journal.Remove(item);
                }
                else if (command == "Combine Items")
                {
                    string[] current = tokens[1].Split(":", StringSplitOptions.RemoveEmptyEntries);
                    string oldItem = current[0];
                    string newItem = current[1];

                    if (journal.Contains(oldItem))
                    {
                        journal.Insert(journal.IndexOf(oldItem) + 1, newItem);
                    }
                }
                else if (command == "Renew")
                {
                    if (journal.Contains(item))
                    {
                        int index = journal.IndexOf(item);
                        string element = journal[index];
                        journal.Add(element);
                        journal.RemoveAt(index);
                    }
                }



                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",journal));
        }
    }
}
