using System;

namespace FarmFeeding
{
    class Program
    {
        // Global variables



        list<string> species = new list<string>() { "Sheep", "Pig", "Cow", "Chicken" };



        // Methods and/or function

        // Check to see if an interger enter by a user is within range
        static int CheckSpecies(string question, int min, int max)
        {
            Console.WriteLine(question);

            while(true)
            {
                try
                {
                    int userInt = Convert.ToInt32(Console.ReadLine());

                    if (userInt >= min && userInt <= max)
                    {
                        return userInt;
                    }
                    Console.WriteLine($"Error: Please enter a number between {min} and {max\n}");
                }
                catch
                {
                    Console.WriteLine($"Error: Please enter a number between {min} and {max\n}");
                }
            }
        }

        static void FarmFeeding()
        {
            // Decide which species is used
            string species = CheckSpecies("Choose a species:\n" +
                "1. Sheep\n" +
                "2. Pig\n" +
                "3. Cow\n" +
                "4. Chicken\n" +
                "5. Quit\n", 1, 5);

            Console.Clear();
        }

        static void main()
        {

        }
    }

}
