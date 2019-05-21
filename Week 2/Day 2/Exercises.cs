using System;
namespace ClassExamples
{
    class Exercise1

    {
        static void Main(string[] args)
        {
            // Ask for age
            Console.WriteLine("Please insert your age");

            // Store input into variable
            int Answer = int.Parse(Console.ReadLine());

            // Create restrictions for answers
            while (Answer <= 0 || Answer >= 150)
            {
                Console.WriteLine("Wrong input. Please try again: ");

                // No need to define type for Answer again (int Answer produces error)
                Answer = int.Parse(Console.ReadLine());
            }

            if (Answer > 65)
                Console.WriteLine("You're a senior");
            else if (Answer < 18)
                Console.WriteLine("You're underage");
            else
                Console.WriteLine("You're a young adult");
        }


        /*
         * 
         */


        class Exercise2
        {
            static void Main(string[] args)
            {
                // Ask for two numbers
                Console.WriteLine("Please input two numbers:");
                int one = int.Parse(Console.ReadLine());
                int two = int.Parse(Console.ReadLine());

                // Initialize two booleans
                bool bool1, bool2;

                // Generate booleans
                Random rand = new Random();
                int random = rand.Next(0, 1);
                if (random == 1)
                    bool1 = true;
                else
                    bool1 = false;
                random = rand.Next(0, 1);
                if (random == 1)
                    bool2 = true;
                else
                    bool2 = false;

                // Initialize output variable
                int output;

                // Outputs for exercise
                if ((bool1 && bool2) == false)
                {
                    output = one + two;
                    Console.WriteLine(output);
                }
                else if ((bool1 || bool2) == false)
                {
                    output = one - two;
                    Console.WriteLine(output);
                }
                else if ((bool1 == false) && one > 5)
                {
                    output = one * two;
                    Console.WriteLine(output);
                }
                else if ((bool2 == true) && (((one + two) > 45) && ((one % two) == 0)))
                    Console.WriteLine("Something");
            }
        }
    }
}
