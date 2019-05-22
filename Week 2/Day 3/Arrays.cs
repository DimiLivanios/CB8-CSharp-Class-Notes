using System;
namespace Day3
{
    class Arrays
    {
        static void Main(string[] args)
        {
            // We declare arrays using []. Here we initialize an integer array.
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            // To list the i-th element of an array we use array[i]
            for (int i = 0; i <= 5; i++)
                Console.WriteLine(numbers[i]);

            // To assign a value to the i-th element:
            numbers[5] = 100;

            // To create an empty array which fits n elements:
            Console.WriteLine("What size do you want your array?");
            int size = int.Parse(Console.ReadLine());
            int[] array1 = new int[size];

            // Arrays have a length property. To retrieve it we use array.Length
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
                /* The default element for integers is 0, so when an array is 
                 * initialized it is filled with zeroes.
                 */
            }

            // Let us now initialize a two-dimensional array
            int[,] array = { { 1, 2, 5 }, { 3, 4, 100 }, { 5, 6, 4} }; // 3x3 matrix
            /* Number of commas in int[,] define the number of dimensions in the
             * array. All rows need the same number of columns.
             */

            /* To transverse an array we use nested loops, which means as many loops
             * as there are dimensions.
             */

            for (int i = 0; i < array.GetLength(0); i++) 
            // Length of 0-th dimension (1-st but we use zero-indexing)
            {
                for (int j = 0; j < array.GetLength(1); j++) // Need to use different variables
                {
                    Console.WriteLine(array[i, j]);
                }
            }

            // We can use the same method to fill up an array

            // As above, to initialize an empty multi-dimensional array
            int[,] array2 = new int[rows, columns];


            // Arrays of custom row lengths are called jagged arrays
            int[][] JaggedArray = new int[3][];
            // 2nd-order array (array of arrays) with 3 rows
            JaggedArray[0] = new int[5];
            // 0-th element of JaggedArray is an array of length 5


            //Console.ReadKey()
        }
    }
}
