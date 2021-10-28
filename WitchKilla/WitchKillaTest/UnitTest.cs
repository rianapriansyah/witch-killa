using System;
using System.Collections.Generic;
using WitchKilla;
using Xunit;

namespace WitchKillaTest
{
    public class UnitTest
    {

        [Fact]
        public void Witch_Killing_Rule_Year1_Return_Correct()
        {
            int numberOfVillagerKilled = WitchKillingRule.GetNumberOfPeopleKilledByYear(1);

            Assert.Equal(1, numberOfVillagerKilled);
        }

        [Fact]
        public void Witch_Killing_Rule_Year3_Return_Correct()
        {
            int numberOfVillagerKilled = WitchKillingRule.GetNumberOfPeopleKilledByYear(3);

            Assert.Equal(4, numberOfVillagerKilled);
        }

        [Fact]
        public void Witch_Killing_Rule_Return_Correct_Sequence()
        {
            List<int> rule = new List<int>()
            {
                1,2,4,7,12
            };

            List<int> actual = new List<int>();

            for (int i = 1; i <= rule.Count; i++)
            {
                int numberOfVillagerKilled = WitchKillingRule.GetNumberOfPeopleKilledByYear(i);
                actual.Add(numberOfVillagerKilled);
            }

            Assert.Equal(rule, actual);
        }
    }
}
