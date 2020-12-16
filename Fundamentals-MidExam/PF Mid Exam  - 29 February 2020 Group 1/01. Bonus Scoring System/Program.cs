using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int countStudent = int.Parse(Console.ReadLine());
            int countLecture = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());

            double maxBonus = 0;
            int maxAttendance = 0;

            for (int i = 0; i < countStudent; i++)
            {
                int attendance = int.Parse(Console.ReadLine());
                double totalBonus = attendance * 1.0 / countLecture
                * (5 + initialBonus);

                if (maxBonus<totalBonus)
                {
                    maxBonus = totalBonus;
                }
                if (maxAttendance<attendance)
                {
                    maxAttendance = attendance;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");
        }
    }
}
