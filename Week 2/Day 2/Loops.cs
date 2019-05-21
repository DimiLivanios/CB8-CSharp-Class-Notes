using System;

namespace ClassExamples
{
    public class Loops
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a number: ");

            // Cannot assign string to int
            int number = Console.ReadLine();

            // Two ways to input string as number
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            int number1 = int.Parse(Console.ReadLine());

            Random rand = new Random();

            // Different ways to add to a variable
            int a = 1;
            a = a + 1;

            Console.WriteLine(a);

            a += 1; // (Same thing)

            Console.WriteLine(a);

            a++; // (Same thing)

            Console.WriteLine(a);

            // And, similarly
            a--;

            Console.WriteLine(a);

            // Note, however, that
            Console.WriteLine(a++); // Prints out a, since it evaluates the expression from left to right

            /* Here, the process followed is
             * Console.WriteLine(a);
             * a++; */            


            // To solve for this, we write
            Console.WriteLine(++a);

            /* Where the process followed is
             * a++;     
             * Console.WriteLine(a); */

            // Program-defined loop iterations
            for (int i = 0; i < 10; i++)
            {
                if (number1 == rand.Next(1, 7))
                    Console.WriteLine("You win!");
                else
                    Console.WriteLine("You lose!");
            }

            // User-defined loop iterations
            Console.WriteLine("How many times do you wanna play?");
            int times = int.Parse(Console.ReadLine());

            for (int i = 0; i < times; i++)
            {
                if (number1 == rand.Next(1, 7))
                    Console.WriteLine("You win!");
                else
                    Console.WriteLine("You lose!");
            }

            // Undefined loop iterations
            Console.WriteLine("Please insert a number");
            int number2 = int.Parse(Console.ReadLine());
            while (number2 != rand.Next(1, 7)) 
            {
                Console.WriteLine("You lose!");
                Console.WriteLine("Insert another number");
                number2 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("You win!");
        }
    }
}
