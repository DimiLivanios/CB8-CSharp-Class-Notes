using System;
namespace Day4
{
    class Classes
    {
        static void Main(string[] args)
        {
            /* (1) A class is a "template" for an object which is called using 
             * the 'new' function, which in turn produces an object of that 
             * template. This allows us to modularize code (break it into 
             * smaller, more compact pieces). Thus, to use a class created 
             * elsewhere, we call it in here.
             */

            Dice dice1 = new Dice();
            Console.WriteLine(dice1.Number1); /* (6) As we can see, we can only 
                                               * choose the Number1 and Number2
                                               * objects from dice1 - Number is 
                                               * unavailable. We can also see 
                                               * that Number1 only initializes 
                                               * an integer. As a result, our 
                                               * output is '0'.                                              
                                               */

            dice1.Roll(); // (7) This is how we call a method.
            Console.WriteLine(dice1.Number2);
                                                                                            
        }
    }

    /* (2) This piece of code would usually be placed in a separate file, like 
     * Dice.cs
     */    
    class Dice

    // (3) This part of the code is only accessible within Dice.
    {
        int Number; /* (4) this is equivalent to putting 'private' before int.
                     * To override this, and make it callable from outside Dice,
                     * we declare it as public.
                     */

        public int Number1; /* (5) There is also the 'internal' modifier/
                             * property, which makes the variable/method 
                             * callable within the same project.
                             */                            

        public int Number2;
        
        public void Roll() /* (7) All methods in C# have a type. If we want our 
                            * method to return a value, it needs to contain a 
                            * return statement within the method. Otherwise, we 
                            * need to declare our method as being a void method 
                            * (one that does not return a value).
                            */                           
        {
            Random dice = new Random();
            Number2 = dice.Next(1, 7);
        }
    }
}
