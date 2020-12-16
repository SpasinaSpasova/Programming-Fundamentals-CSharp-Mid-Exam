using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {

            int waitingPeopleForLift = int.Parse(Console.ReadLine());

            int[] currentStetOfTheLift = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < currentStetOfTheLift.Length; i++)
            {

                while (currentStetOfTheLift[i] != 4)
                {
                    currentStetOfTheLift[i]++;
                    waitingPeopleForLift--;
                    if (waitingPeopleForLift <= 0)
                    {
                        break;
                    }
                }
                if (waitingPeopleForLift <= 0)
                {
                    break;
                }


            }

            for (int i = 0; i < currentStetOfTheLift.Length; i++)
            {
                if (currentStetOfTheLift[i] < 4 && waitingPeopleForLift <= 0)
                {
                    Console.WriteLine("The lift has empty spots!");
                    Console.WriteLine(string.Join(" ", currentStetOfTheLift));
                    return;
                }
            }
            if (waitingPeopleForLift > 0)
            {
                Console.WriteLine($"There isn't enough space! {waitingPeopleForLift} people in a queue!");
                Console.WriteLine(string.Join(" ", currentStetOfTheLift));

            }
            else if (waitingPeopleForLift == 0 && currentStetOfTheLift.All(x => x == 4))
            {
                Console.WriteLine(string.Join(" ", currentStetOfTheLift));

            }
        }


    }

}


