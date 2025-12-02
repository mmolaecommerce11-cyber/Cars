using System;

namespace Cars
{
    class CarsProgram
    {
        static void Main(string[] args)
        {
            // 2D multidimensional array (rows x columns)
            int[,] numbers =
            {
                { 1, 4, 2 },
                { 5, 9, 7 },
                { 3, 6, 8 }
            };

            // Loop through rows
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                // Loop through columns
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    Console.Write(numbers[row, col] + " ");
                }

                Console.WriteLine(); // move to next row
            }
        }
    }
}

