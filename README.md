# task-3
using System;

namespace Task3App
{
    class Task3
    {
        static void Main(string[] args)
        {
            // Declare and initialize the array
            int[] numbers = { 3, 7, 12, 19, 21, 25, 30 };

            // Ask the user for input
            Console.Write("Enter a number to search for: ");
            int target = int.Parse(Console.ReadLine());

            bool found = false;

            // Use a for loop to search through the array
            for (int i = 0; i < numbers.Length; i++)
            {
                // Check if the current element matches the target
                if (numbers[i] == target)
                {
                    Console.WriteLine("Number found at position " + i + "!");
                    found = true;
                    break; // Exit the loop immediately
                }
            }

            // If the number was not found
            if (!found)
            {
                Console.WriteLine("Number not found in the list.");
            }
        }
    }
}
