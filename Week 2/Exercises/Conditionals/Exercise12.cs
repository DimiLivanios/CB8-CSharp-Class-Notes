using System;
namespace Conditionals
{
    enum Exercise12Options
    {
        Addition = 1,
        Subtraction,
        Multiplication,
        Division,
        Exit
    }
    class Exercise12
    {
        static void Main(string[] args)
        {
            string answer = "y";
            do
            {
                Console.WriteLine("Enter the first Integer");
                double first = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second Integer");
                double second = double.Parse(Console.ReadLine());
                Console.WriteLine("Here are the options:");
                string[,] array = { { "1", "Addition" }, { "2", "Subtraction" }, { "3", "Multiplication" }, { "4", "Division" }, { "5", "Exit" } };
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Console.WriteLine($"{ array[i,0]} - { array[i,1]}");
                }
                Console.WriteLine("Input your choice");
                int Choice = int.Parse(Console.ReadLine());
                Exercise12Options SelectionOutput = (Exercise12Options)Choice;
                switch (SelectionOutput)
                {
                    case Exercise12Options.Addition:
                        Console.WriteLine(first + second);
                        break;
                    case Exercise12Options.Subtraction:
                        Console.WriteLine(first - second);
                        break;
                    case Exercise12Options.Multiplication:
                        Console.WriteLine(first * second);
                        break;
                    case Exercise12Options.Division:
                        Console.WriteLine(first / second);
                        break;
                    case Exercise12Options.Exit:
                        break;
                    default:
                        Console.WriteLine("Wrong input, try again");
                        break;
                }
                Console.WriteLine("Want to do another calculation? (y/n)");
                answer = Console.ReadLine();
            } while (answer == "y");

            //Console.ReadLine();
        }
    }
}
