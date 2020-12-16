using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int index = int.Parse(command[1]);
                int value = int.Parse(command[2]);

                switch (command[0])
                {
                    case "Shoot":

                        if (index < 0 || index >= targets.Count)
                        {
                            input = Console.ReadLine();

                            continue;
                        }

                        targets[index] -= value;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                        break;

                    case "Add":
                        if (index < 0 || index >= targets.Count)
                        {
                            Console.WriteLine("Invalid placement!");
                            input = Console.ReadLine();
                            continue;
                        }

                        targets.Insert(index, value);


                        break;
                    case "Strike":
                        if (index - value < 0 || index + value >= targets.Count)
                        {
                            Console.WriteLine("Strike missed!");
                            input = Console.ReadLine();
                            continue;
                        }
                        for (int i = index - value; i <= index + value; i++)
                        {
                            targets.RemoveAt(index - value);
                        }
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join("|", targets));
        }
    }
}
