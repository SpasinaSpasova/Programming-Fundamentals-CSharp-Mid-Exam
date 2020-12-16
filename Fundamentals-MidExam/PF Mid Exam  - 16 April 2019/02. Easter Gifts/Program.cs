using System;
using System.Linq;

namespace _02._Easter_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gifts = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string input = Console.ReadLine();

            while (input != "No Money")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = tokens[0];
                string currentGift = tokens[1];

                if (command == "OutOfStock")
                {
                    for (int i = 0; i < gifts.Length; i++)
                    {
                        if (gifts[i] == currentGift)
                        {
                            gifts[i] = "None";
                        }
                    }
                }
                else if (command == "Required")
                {
                    int index = int.Parse(tokens[2]);

                    if (index >= 0 && index < gifts.Length)
                    {
                        gifts[index] = currentGift;
                    }
                }
                else if (command == "JustInCase")
                {
                    gifts[gifts.Length - 1] = currentGift;
                }
                input = Console.ReadLine();
            }


            Console.WriteLine(string.Join(" ", gifts.Where(x => x != "None")));
        }
    }
}
