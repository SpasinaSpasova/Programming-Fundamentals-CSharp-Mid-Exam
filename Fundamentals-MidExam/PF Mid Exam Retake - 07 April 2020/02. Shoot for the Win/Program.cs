
using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();
            int count = 0;
            while (input != "End")
            {
                int index = int.Parse(input);

                if (index >= 0 && index < targets.Length)
                {
                    int currentTarget = targets[index];

                    if (targets[index] != -1)
                    {
                        targets[index] = -1;
                        count++;

                        for (int i = 0; i < targets.Length; i++)
                        {
                            if (targets[i] == -1)
                            {
                                continue;
                            }
                            else
                            {
                                if (targets[i]<=currentTarget)
                                {
                                    targets[i] += currentTarget;
                                }
                                else
                                {
                                    targets[i] -= currentTarget;
                                }
                            }
                        }
                    }
                }



                input = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {count} -> {string.Join(" ",targets)}");

        }
    }
}
