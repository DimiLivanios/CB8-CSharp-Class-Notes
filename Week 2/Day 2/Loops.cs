using System;
namespace Day4
{
    class MathOperations
    {
        static void Main(string[] args)
        {
            /* There is a useful library in .NET called Math. It contains useful
             * objects like pi
             */
            double pi = Math.PI;
            Console.WriteLine(pi);

            // Float in .NET is an alias for a data type called Single
            string String = "3.14";
            float pi2 = float.Parse(String);
            float pi3 = Convert.ToSingle(String);

            //Console.ReadKey();
        }
    }
}
