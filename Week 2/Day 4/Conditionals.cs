using System;
namespace Day4
{
    class Conditionals
    {
        static void Main(string[] args)
        {
            /* If we have two cases for a conditional, we can use a ternary
             * operator
             */
            int int1 = 1;
            int int2 = 2;
            string message = int1 == int2
                ? $"{int1} and {int2} are equal" /* ? is a ternary operator.
                                                  * Translates to "then" (implication
                                                  * to the condition int1 == int2
                                                  */
                : $"{int1} and {int2} are not equal."; // : translates to "otherwise"
          }
    }
}