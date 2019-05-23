using System;
namespace Day3
{
    class Switch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a number from 1-7");
            int number = int.Parse(Console.ReadLine());

            /* To avoid repeating if (number == 1)
             * (...)           
             * else if(number == 2)
             * (...)
             * .
             * .
             * .
             * We can write
             */

            switch (number)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break; /* We need breaks because we do not use curly brackets
                            * breaks completely stop the switch and get out of it
                            */
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sudnay");
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }

            /* To avoid repeating if (number == 1 || number == 2 || ...)
             * (...)
             * else if (number == 6 || number == 7)
             *
             * We can write 
             */

            switch (number)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Week");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;

            }

            //Console.ReadKey();
        }
    }
}
