using System;

namespace _01._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int totalPeopleCount = int.Parse(Console.ReadLine());

            int peoplePerHour = first + second + third;

            int hour = 0;

            while (totalPeopleCount>0)
            {
                totalPeopleCount -= peoplePerHour;
                hour++;
                if (hour%4==0)
                {
                    hour++;
                }
            }
            Console.WriteLine($"Time needed: {hour}h.");
        }
    }
}
