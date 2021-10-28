using System;
using System.Collections.Generic;
using System.Linq;

namespace WitchKilla
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Please insert the number of people");
                int.TryParse(Console.ReadLine(), out int count);
                List<int> killedPeople = new List<int>();
                double avg = -1;

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(string.Format("Please insert person {0} Age of death", i + 1));
                    int.TryParse(Console.ReadLine(), out int ageOfDeath);

                    Console.WriteLine(string.Format("Please insert person {0} Year of death", i + 1));
                    int.TryParse(Console.ReadLine(), out int yearOfDeath);

                    int year = yearOfDeath - ageOfDeath;

                    if(year < 0)
                    {
                        Console.WriteLine(string.Format("{0}", avg));
                        break;
                    }

                    int numberOfPeopleKilled = GetNumberOfPeopleKilledByYear(year);
                    killedPeople.Add(numberOfPeopleKilled);
                }

                avg = killedPeople.Average();
                Console.WriteLine(string.Format("The average number of people the witch killed on year of birth of those people is \n{0}", avg));

            }
            while (true);
        }

        private static int GetNumberOfPeopleKilledByYear(int year)
        {
            int number = year;
            int[] Fib = new int[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;
            int x = Fib[0] + Fib[1];
            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
                x += Fib[i];
            }
            return x;
        }
    }
}
