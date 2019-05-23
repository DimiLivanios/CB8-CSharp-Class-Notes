
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
            // (8) Suppose we want to roll a second die. 
            dice1.Roll();
            Console.WriteLine(dice1.Number2);
            dice1.Roll();
            Console.WriteLine(dice1.Number2);
            /* (9) We will notice that the two outputs are identical. This is 
             * due to the fact that the processor is so fast that it performs 
             * the 'Random dice' initialization operations before the seed 
             * changes. To solve for this we initialize a private Random object 
             * which is only accessible within the single Roll() instance.
             * Likewise, we only initialize dice2 once and then roll it 
             * consecutively, to avoid what we get in (11).       
             */
            Dice2 dice2 = new Dice2();
            dice2.Roll();
            Console.WriteLine(dice2.Number);
            dice2.Roll();
            Console.WriteLine(dice2.Number);

            /* (11) If we initialize dice2 AND roll it two times consecutively, 
             * we once again get the issue in (8).
             */
            Dice2 dice3 = new Dice2();
            dice3.Roll();
            Console.WriteLine(dice3.Number);
            dice3 = new Dice2();
            dice3.Roll();
            Console.WriteLine(dice3.Number);


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

    // (10) Here, we have initialized dice only once, privately.
    class Dice2
    {
        public int Number;
        private Random dice = new Random();
        public void Roll()
        {
            Number = dice.Next(1, 7);
        }
    }
}
