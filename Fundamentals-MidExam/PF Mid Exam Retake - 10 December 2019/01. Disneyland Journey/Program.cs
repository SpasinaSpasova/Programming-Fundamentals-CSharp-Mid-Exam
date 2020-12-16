using System;

namespace _01._Disneyland_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double theMoney = 0;
           
            for (int i = 1; i <= months; i++)
            {
                if (i != 1 && i % 2 != 0)
                {
                    theMoney -= theMoney * 0.16;
                  

                }
               
                if (i % 4 == 0)
                {
                    theMoney += (theMoney * 25) / 100;
                }

                theMoney += neededMoney * 0.25 ;

            }

            if (theMoney >= neededMoney)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {(theMoney-neededMoney):f2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {Math.Abs(theMoney - neededMoney):f2}lv. more.");
            }
        }
    }
}
