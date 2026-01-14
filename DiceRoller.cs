using System;

namespace DiceSimulator
{
    public class DiceRoller
    {
        // Method to simulate the rolls and return an array of results
        public int[] SimulateRolls(int numberOfRolls)
        {
            // Array to store counts for sums 2 through 12. 
            // We use size 13 so the index matches the sum (index 0 and 1 go unused).
            int[] rollCounts = new int[13]; 
            Random rnd = new Random();

            for (int i = 0; i < numberOfRolls; i++)
            {
                int die1 = rnd.Next(1, 7); // Roll first 6-sided die 
                int die2 = rnd.Next(1, 7); // Roll second 6-sided die 
                int sum = die1 + die2;

                rollCounts[sum]++; // Increment the count for that specific sum [cite: 3]
            }

            return rollCounts; // Return the results to the first class [cite: 6]
        }
    }
}