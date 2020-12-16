using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            double avarage = numbers.Average();

            numbers.RemoveAll(x => x <= avarage);


            numbers.Sort();
            numbers.Reverse();

            if (numbers.Count >= 5)
            {
                Console.WriteLine(string.Join(" ", numbers.GetRange(0, 5)));

            }
            else if (numbers.Count > 0 && numbers.Count < 5)
            {
                Console.WriteLine(string.Join(" ", numbers));

            }
            else if (numbers.Count == 0)
            {
                Console.WriteLine("No");
            }



        }
    }
}
