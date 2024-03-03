// imports
using System;
using System.Collections.Generic;

namespace FarmFeeding
{
    class Program
    {
        // Global variables
        List<string> Species = new List<string>() { "Sheep", "Pig", "Cow", "Chicken" };
        List<string> sheepBreed = new List<string>() { "Romney", "Hampshire", "Dorset", "Rambouillet" };
        List<string> pigBreed = new List<string>() { "KuneKune", "Hampshire", "Berkshire", "Chester White" };
        List<string> cowBreed = new List<string>() { "Angus", "Hereford", "Holstein", "Friesian" };
        List<string> chickenBreed = new List<string>() { "Leghorn", "Rhode Island Red", "Dorking", "Araucana" };
        static int Flag = 0;
        static int Sheep = 0;
        static int Pig = 0;
        static int Cow = 0;
        static int Chicken = 0;
        
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
                    Console.WriteLine($"Error: Please enter a number between {min} and {max}\n");
                }
                catch
                {
                    Console.WriteLine($"Error: Please enter a number between {min} and {max}\n");
                }
            }
        }
        static int CheckSheep(string question, int min, int max)
        {
            Console.WriteLine(question);

            while (true)
            {
                try
                {
                    int userInt = Convert.ToInt32(Console.ReadLine());

                    if (userInt >= min && userInt <= max)
                    {
                        return userInt;
                    }
                    Console.WriteLine($"Error: Please enter a number between {min} and {max}\n");
                }
                catch
                {
                    Console.WriteLine($"Error: Please enter a number between {min} and {max}\n");
                }
            }
        }
        static int CheckPig(string question, int min, int max)
        {
            Console.WriteLine(question);

            while (true)
            {
                try
                {
                    int userInt = Convert.ToInt32(Console.ReadLine());

                    if (userInt >= min && userInt <= max)
                    {
                        return userInt;
                    }
                    Console.WriteLine($"Error: Please enter a number between {min} and {max}\n");
                }
                catch
                {
                    Console.WriteLine($"Error: Please enter a number between {min} and {max}\n");
                }
            }
        }
        static int CheckCow(string question, int min, int max)
        {
            Console.WriteLine(question);

            while (true)
            {
                try
                {
                    int userInt = Convert.ToInt32(Console.ReadLine());

                    if (userInt >= min && userInt <= max)
                    {
                        return userInt;
                    }
                    Console.WriteLine($"Error: Please enter a number between {min} and {max}\n");
                }
                catch
                {
                    Console.WriteLine($"Error: Please enter a number between {min} and {max}\n");
                }
            }
        }
        static int CheckChicken(string question, int min, int max)
        {
            Console.WriteLine(question);

            while (true)
            {
                try
                {
                    int userInt = Convert.ToInt32(Console.ReadLine());

                    if (userInt >= min && userInt <= max)
                    {
                        return userInt;
                    }
                    Console.WriteLine($"Error: Please enter a number between {min} and {max}\n");
                }
                catch
                {
                    Console.WriteLine($"Error: Please enter a number between {min} and {max}\n");
                }
            }
        }

        static void FarmFeeding()
        {
            // Decide which species is used
            if (Species > 0)
            {
                int Species = CheckSpecies("Choose a species:\n" +
                "1. Sheep\n" +
                "2. Pig\n" +
                "3. Cow\n" +
                "4. Chicken\n" +
                "5. Quit\n", 1, 5);
            }
            // Decide which breed is used
            else if (Sheep > 1) 
            {
                int sheepBreed = CheckSheep("Choose a Sheep breed:\n" +
                    "1. Romney\n" +
                    "2. Hampshire\n" +
                    "3. Dorset\n" +
                    "4. Rambouillet\n" +
                    "5. Quit\n", 1, 5);
            }
            else if (Pig > 2)
            {
                int pigBreed = CheckPig("Choose a Pig breed:\n" +
                    "1. KuneKune\n" +
                    "2. Hampshire\n" +
                    "3. Berkshire\n" +
                    "4. Chester White\n" +
                    "4. Quit\n", 1, 5);
            }
            else if (Cow > 3)
            {
                int cowBreed = CheckCow("Choose a Cow breed:\n" +
                    "1. Angus\n" +
                    "2. Hereford\n" +
                    "3. Holstein\n" +
                    "4. Friesian\n" +
                    "5. Quit\n", 1, 5);
            }
            else if (Chicken > 4)
            {
                int chickenBreed = CheckChicken("Choose a Chicken breed:\n" +
                    "1. Leghorn\n" +
                    "2. Rhode Island Red\n" +
                    "3. Dorking\n" +
                    "4. Araucana\n" +
                    "5. Quit\n", 1, 5);
            }

            if (Species != 5)
            {
                Flag = 5;
            }

        }

        static void Main()
        {
            while (Flag != 5)
            {
                FarmFeeding();
            }

            Console.ReadLine();
            Console.Clear();
        }
    }

}
