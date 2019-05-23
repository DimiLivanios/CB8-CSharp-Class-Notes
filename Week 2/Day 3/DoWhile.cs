using System;
namespace Day3
{
    class DoWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number (1-6): ");
            int number = int.Parse(Console.ReadLine());

            Random dice = new Random();
            if (dice.Next(1, 7) == number)
                Console.WriteLine("You win");
            else
                Console.WriteLine("You lose");

            Console.WriteLine("Want to play again? (y/n)");
            string answer = Console.ReadLine();

            while (answer == "y") ;
            {
                Console.WriteLine("Pick a number (1-6): ");
                number = int.Parse(Console.ReadLine());
                if (dice.Next(1, 7) == number)
                    Console.WriteLine("You win");
                else
                    Console.WriteLine("You lose");
                Console.WriteLine("Want to play again? (y/n)");
                answer = Console.ReadLine();
            }

            /* As you will notice above, we have repetition of code. We can 
             * instead initialize an answer and avoid repetition
             */

            string answer = "n";
            while (answer == "y")
            {
                Console.WriteLine("Pick a number (1-6): ");
                int number = int.Parse(Console.ReadLine());

                Random dice = new Random();
                if (dice.Next(1, 7) == number)
                    Console.WriteLine("You win");
                else
                    Console.WriteLine("You lose");

                Console.WriteLine("Want to play again? (y/n)");
                answer = Console.ReadLine();
            }

            /* However, the problem with while is that it depends on initializing
             * a condition. If we make a mistake and initialize answer = "n", the
             * loop will never start. If we want to run at least once, we use do-
             * -while
             */

            do
            {
                Console.WriteLine("Pick a number (1-6): ");

                /* Note that we have a second initialization of the variable
                 * number. This is because the variable is local within the block
                 */
                int number = int.Parse(Console.ReadLine());

                Random dice = new Random();
                if (dice.Next(1, 7) == number)
                    Console.WriteLine("You win");
                else
                    Console.WriteLine("You lose");

                Console.WriteLine("Want to play again? (y/n)");

                /* Note that answer needs to be initialized outside of the loop.
                 * if that was not the case, the line below would not work.
                 */
                answer = Console.ReadLine();
            } while (answer == "y");
            /* We can instead write while (Console.ReadLine() == "y") and delete
             * the assignment of answer within the block   
             */

            //Console.ReadKey()
        }
    }
}
