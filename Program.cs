using System;

namespace DiceSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!"); // [cite: 10]
            Console.Write("How many dice rolls would you like to simulate? "); // 
            
            // Get user input for number of rolls [cite: 4]
            if (int.TryParse(Console.ReadLine(), out int numRolls))
            {
                // Instantiate the second class and get the results 
                DiceRoller dr = new DiceRoller();
                int[] results = dr.SimulateRolls(numRolls);

                Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS"); // [cite: 12]
                Console.WriteLine("Each \"*\" represents 1% of the total number of rolls."); // [cite: 13]
                Console.WriteLine($"Total number of rolls = {numRolls}.\n"); // [cite: 13]

                // Loop through possible sums (2 to 12) to print the histogram 
                for (int i = 2; i <= 12; i++)
                {
                    // Calculate percentage (Sum / Total * 100) [cite: 8]
                    double percentage = (double)results[i] / numRolls * 100;
                    
                    // Round to nearest integer for asterisk count [cite: 37]
                    int asterisksCount = (int)Math.Round(percentage);

                    Console.Write($"{i}: ");
                    Console.WriteLine(new string('*', asterisksCount)); // Print '*' for each 1% [cite: 8, 15]
                }

                Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!"); // [cite: 36]
            }
        }
    }
}