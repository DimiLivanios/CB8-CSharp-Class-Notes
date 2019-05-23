using System;
namespace Day4
{
    class Characters
    {
        static void Main(string[] args)
        {
            // We use single '' to render characters. Strings are arrays of characters
            char char1 = 'a';

            // Every character has a corresponding integer value, depending on encoding
            Console.WriteLine((int)char1); // Prints out 97

            // Likewise, we can cast an integer into a character
            Console.WriteLine((char)97); // Prints out 'a'.

            // \n changes line (note the forward slash)
            Console.WriteLine("\n Hello, World! \n";
            /* The forward slash in this case is called an escape character.
             * An escape character modifies a following string or character's
             * function (in this case n is not 'n' but a line change).
             */            
        }
    }
}
