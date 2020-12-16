using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int wins = 0;
            //int battle = 0;
            string input = Console.ReadLine();

            while (input!= "End of battle")
            {
                int distance = int.Parse(input);
                //battle++;
                if (energy<distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                    break;
                }
                wins++;
                energy -= distance;
                if (wins%3==0)
                {
                    energy += wins;
                }
               
                input = Console.ReadLine();
            }

            if (input== "End of battle")
            {
                Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");
            }
        }
    }
}
