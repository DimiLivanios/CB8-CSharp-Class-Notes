using System;
namespace Day3
{
    public class MoreLoops
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                // Continue makes us go to the next iteration of the loop
                if (i % 2 != 0)
                    continue;

                /* Break will stop the loop. But given we have reached 
                 * continue above the code below is skipped
                 */
                if (i == 51)
                    break;
                Console.WriteLine(i);
            }

            // This will never run
            while (false)
            {

            }

            // This will always run, forever
            while (true)
            {

            }
            //Console.Readkey()
        }
    }
}
