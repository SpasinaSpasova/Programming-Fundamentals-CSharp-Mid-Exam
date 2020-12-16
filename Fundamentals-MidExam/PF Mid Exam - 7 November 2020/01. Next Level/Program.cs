using System;
using System.Security.Cryptography;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededExp = double.Parse(Console.ReadLine());
            int battlesCount = int.Parse(Console.ReadLine());

            double exp = 0;

            int count = 0;
            for (double i = 1; i <= battlesCount; i++)
            {
                double currentExp = double.Parse(Console.ReadLine());
                exp += currentExp;
                count++;
                if (exp == neededExp)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {count} battles.");

                    return;
                }

                if (i % 3 == 0)
                {
                    exp += 0.15 * currentExp;
                   
                }
                if (i % 5 == 0)
                {
                    exp -= 0.1 * currentExp;
                   
                }
                if (i % 15 == 0)
                {
                    exp += 0.05 * currentExp;

                }
              

            }
            double expNeeded = neededExp - exp;
            if (neededExp<=exp)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {count} battles.");
            }
            else
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {expNeeded:f2} more needed.");
            }

        }
    }
}