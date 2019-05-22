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
            Console.WriteLine("Enter the first Integer");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second Integer");
            double second = double.Parse(Console.ReadLine());
            Console.WriteLine("Here are the options:");
            for (int i = 1; i <= 5; i++)
            {
                Exercise12Options Choices = (Exercise12Options)i;
                switch (Choices)
                {
                    case Exercise12Options.Addition:
                        Console.WriteLine("1 - Addition");
                        break;
                    case Exercise12Options.Subtraction:
                        Console.WriteLine("2 - Subtraction");
                        break;
                    case Exercise12Options.Multiplication:
                        Console.WriteLine("3 - Multiplication");
                        break;
                    case Exercise12Options.Division:
                        Console.WriteLine("4 - Division");
                        break;
                    case Exercise12Options.Exit:
                        Console.WriteLine("5 - Exit");
                        break;
                }
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
            }
        }
    }
}
