using System;
namespace ClassExamples
{
    class Conditionals
    {
        static void Main(string[] args)
        {
            Console.Write("Type your name: ");
            string name = Console.ReadLine();
            // We can also declare booleans
            bool b = true;
            bool c = false;

            if(name == "Computer")
                // One line of code in conditional doesn't need curly brackets
                Console.WriteLine("We have the same name!");
            else
                // Multiple lines of code need curly brackets to group conditional block
            {
                Console.WriteLine("Hello, " + name);
                // Two additional ways to write in console
                Console.WriteLine("What's up, {0} {1}?", name, "(Surname)");
                Console.WriteLine($"Your name is {name} {"(Surname)"}"); // This is called string interpolation
            }
        }
    }
}
