using System;
namespace Day3
{
    class MoreLoops
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                // Continue makes us go to the next iteration of the loop
                if (i % 2 != 0)
                    continue;

                /* Break will stop the iteration. But given we have reached 
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

            // This is equivalent to
            for(; ; )

            //Console.ReadKey();
        }
    }
}
