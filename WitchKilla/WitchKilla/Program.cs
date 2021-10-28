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
                List<int> killedVillager = new List<int>();
                double avg = 0;

                for (int i = 0; i < count; i++)
                {
                    Console.Write(string.Format("Please insert person {0} Age of death : ", i + 1));
                    int.TryParse(Console.ReadLine(), out int ageOfDeath);

                    Console.Write(string.Format("Please insert person {0} Year of death : ", i + 1));
                    int.TryParse(Console.ReadLine(), out int yearOfDeath);

                    Console.WriteLine("");

                    Person person = new Person()
                    {
                        AgeOfDeath = ageOfDeath,
                        YearOfDeath = yearOfDeath
                    };

                    if(person.YearOfBirth < 0)
                    {
                        avg = -1;
                        break;
                    }
                    else
                    {
                        int numberOfVillagerKilled = WitchKillingRule.GetNumberOfPeopleKilledByYear(person.YearOfBirth);
                        killedVillager.Add(numberOfVillagerKilled);
                    }                    
                }

                if(avg != -1)
                {
                    avg = killedVillager.Average();
                    Console.WriteLine(string.Format("The average number of people the witch killed on year of birth of those people is \n{0}", avg));                    
                }
                else
                {
                    Console.WriteLine(string.Format("{0}", avg));
                }
            }
            while (true);
        }        
    }
}
