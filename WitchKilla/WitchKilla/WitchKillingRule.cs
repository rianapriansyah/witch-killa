using System;
using System.Collections.Generic;
using System.Text;

namespace WitchKilla
{
    public static class WitchKillingRule
    {
        public static int GetNumberOfPeopleKilledByYear(int year)
        {
            int[] fibSequence = new int[year + 1];
            fibSequence[0] = 0;
            fibSequence[1] = 1;
            int villager = fibSequence[0] + fibSequence[1];
            for (int i = 2; i <= year; i++)
            {
                fibSequence[i] = fibSequence[i - 2] + fibSequence[i - 1];
                villager += fibSequence[i];
            }
            return villager;
        }
    }
}
