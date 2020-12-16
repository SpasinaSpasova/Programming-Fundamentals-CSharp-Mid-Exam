using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine()
                 .Split()
                 //.Select(int.Parse)
                 .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split()
                    .ToArray();
                string command = tokens[0];

                if (command == "reverse")
                {
                    int startIndex = int.Parse(tokens[2]);
                    int count = int.Parse(tokens[4]);



                    List<string> part = new List<string>();

                    for (int i = startIndex; i < startIndex+count; i++)
                    {
                        part.Add(sequence[i]);
                       
                    }
                    part.Reverse();
                    int countPart = 0;

                    for (int i = startIndex; i < startIndex+count; i++)
                    {
                        sequence[i]=part[countPart];
                        countPart++;
                    }

                }
                else if (command == "sort")
                {
                    int startIndex = int.Parse(tokens[2]);
                    int count = int.Parse(tokens[4]);


                    List<string> part = new List<string>();

                    for (int i = startIndex; i <startIndex+count; i++)
                    {
                        part.Add(sequence[i]);
                       
                    }
                    part.Sort();
                    int countPart = 0;
                    for (int i = startIndex; i < startIndex+count; i++)
                    {
                        sequence[i] = part[countPart];
                        countPart++;

                    }

                }
                else if (command == "remove")
                {
                    int count = int.Parse(tokens[1]);


                    sequence.RemoveRange(0, count);

                }


                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}
