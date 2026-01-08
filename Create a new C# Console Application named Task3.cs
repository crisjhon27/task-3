# task-3
using System;

namespace Task3App
{
    class Task3
    {
        static void Main(string[] args)
        {
            // Step 2: Declare and initialize the array
            int[] numbers = { 3, 7, 12, 19, 21, 25, 30 };

            // Step 3: Ask the user for input
            Console.Write("Enter a number to search for: ");
            string input = Console.ReadLine();
            int target;

            // Validate input
            if (!int.TryParse(input, out target))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            // Step 4: Use a for loop to search the array
            bool found = false; // flag to track if number is found

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    Console.WriteLine($"Number found at position {i}!");
                    found = true;
                    break; // exit the loop immediately
                }
            }

            // Step 5: If not found, display a message
            if (!found)
            {
                Console.WriteLine("Number not found in the list.");
            }

            // Keep console open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
