using System;

namespace Exercise
{
    class TakeData
    {
       static void Main()
        {
            // Ask for first name
            Console.WriteLine("Please provide your first name");

            string FirstName = Console.ReadLine();
           
            // Ask for last name
            Console.WriteLine("Now, please provide your last name");

            // Store last name
            string LastName = Console.ReadLine();

            // Ask for address
            Console.WriteLine("Now, please provide your city of residence");

            // Store city
            string City = Console.ReadLine();

            // Print out message
            Console.WriteLine("Hello " + FirstName + " " + LastName+"!");
            Console.WriteLine("You live in " + City+"!");
            
        }
    }
}
