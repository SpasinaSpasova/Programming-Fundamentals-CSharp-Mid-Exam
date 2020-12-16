using System;
using System.Linq;

namespace _02._Archery_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] archeryField = Console.ReadLine()
                 .Split("|", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            string input = Console.ReadLine();
            int points = 0;
            while (input != "Game over")
            {
                string[] tokens = input.Split("@", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = tokens[0];
                if (command == "Shoot Left")
                {
                    int index = int.Parse(tokens[1]);
                    int lenght = int.Parse(tokens[2]);

                    if (index >= 0 && index < archeryField.Length)
                    {
                        while (lenght != 0)
                        {
                            if (index > 0)
                            {
                                lenght--;
                                index--;
                            }
                            else if (index == 0)
                            {
                                index = archeryField.Length - 1;
                                lenght--;
                            }
                        }
                        if (archeryField[index]<5)
                        {
                            points += archeryField[index];
                            archeryField[index] = 0;
                        }
                        else
                        {
                            points += 5;
                            archeryField[index] -= 5;
                        }
                    }
                }
                else if (command == "Shoot Right")
                {
                    int index = int.Parse(tokens[1]);
                    int lenght = int.Parse(tokens[2]);
                    if (index >= 0 && index < archeryField.Length)
                    {

                        while (lenght != 0)
                        {
                            if (index < archeryField.Length - 1)
                            {
                                lenght--;
                                index++;
                            }
                            else if (index == archeryField.Length - 1)
                            {
                                index = 0;
                                lenght--;
                            }
                        }

                        if (archeryField[index] < 5)
                        {
                            points += archeryField[index];
                            archeryField[index] = 0;
                        }
                        else
                        {
                            points += 5;
                            archeryField[index] -= 5;
                        }
                    }

                }
                else if (command == "Reverse")
                {
                    Array.Reverse(archeryField);
                }



                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" - ", archeryField));
            Console.WriteLine($"Iskren finished the archery tournament with {points} points!");
        }
    }
}
