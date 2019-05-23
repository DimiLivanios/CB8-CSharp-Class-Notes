using System;
namespace ClassExamples
{
    class Basics
    {
        static void Main(string[] args)
        {
 // Have to declare data type. Can declare many variables' types in same function
            int Number = 0, Number1 = 1;

            Console.WriteLine(Number);
            Console.WriteLine(Number1);

            // Data types, once declared don't change
            string Number; // Will produce an error during compilation

            // Can also create a constant
            const int Number2 = 6;

            Number2 = 5; // Produces error

            Console.WriteLine(Number2);

 // C# considers decimals as doubles, so to declare a float we put an f after the number
            float Pi = 3.14; // Produces error
            float Pi = 3.14f; // This is called casting

            Console.WriteLine(Pi);

       // The output for arithmetic operations is of the same type as the inputs
            int a = 5, b = 10;
             
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.WriteLine("a/b = {0}, a%b = {1}", a / b, a % b);

            float c = 12.0f, d = 10.0f;

            Console.WriteLine(c / d);

    // We can explicitly cast a variable and the output below turns into a float
            Console.WriteLine(a / (float)b);

            // Cannot implicitly cast a double into a float
            double e = 12.3;
            float f = e; 
         // Produces error. Need to explicitly cast if we want to take the risk.

            // WriteLine changes line, while Write stays on the same
            Console.Write("Hello");
            Console.WriteLine(",");
            Console.WriteLine("World");
            Console.Write("!");

            //Console.ReadKey();
        }
    }
}
