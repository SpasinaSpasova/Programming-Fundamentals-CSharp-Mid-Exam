using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();
            int numOfMoves = 0;
            while (input != "end")
            {
                int[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int firstIndex = tokens[0];
                int secondIndex = tokens[1];

                numOfMoves++;
                if (firstIndex == secondIndex
                    || firstIndex < 0
                    || firstIndex >= sequence.Count
                    || secondIndex < 0
                    || secondIndex >= sequence.Count)
                {

                    sequence.Insert(sequence.Count / 2, "-" + numOfMoves.ToString() + "a");
                    sequence.Insert(sequence.Count / 2, "-" + numOfMoves.ToString() + "a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    input = Console.ReadLine();
                    continue;

                }

                if (sequence[firstIndex] == sequence[secondIndex])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {sequence[firstIndex]}!");
                    sequence.Remove(sequence[firstIndex]);
                    if (secondIndex - 1 >= 0)
                    {

                        sequence.RemoveAt(secondIndex - 1);
                    }
                    else
                    {
                        sequence.RemoveAt(secondIndex);
                    }
                   
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
                if (sequence.Count <= 0)
                {
                    Console.WriteLine($"You have won in {numOfMoves} turns!");
                    return;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", sequence));

        }
    }
}
