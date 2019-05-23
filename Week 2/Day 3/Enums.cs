using System;
namespace Enums
{
/* There is a data type called enum which allows us to allocate an item/object 
 * to a corresponding integer. We define it outside our class type because it 
 * is a type of its own. So instead of writing
 * 
 * const Monday = 1
 * const Tuesday = 2
 * .
 * .
 * .
 * 
 * We write 
 */
    enum DaysOfWeek
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
/* This allows us to easily identify the cases in switch as shown in the example
 * below
 */
    class Week
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a number from 1-7");
            int number = int.Parse(Console.ReadLine());

            // Here we cast the number as an object of DaysOfWeek
            DaysOfWeek d = (DaysOfWeek)number;

            switch (d)
            {
                case DaysOfWeek.Monday:
                case DaysOfWeek.Tuesday:
                case DaysOfWeek.Wednesday:
                case DaysOfWeek.Thursday:
                case DaysOfWeek.Friday:
                    Console.WriteLine("Weekday");
                    break;
                case DaysOfWeek.Saturday:
                case DaysOfWeek.Sunday:
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }

            //Console.ReadKey()
        }
    }
}
