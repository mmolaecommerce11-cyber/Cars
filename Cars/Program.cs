using System;

namespace Cars
{
    class CarsProgram
    {
        static void Main(string[] args)
        {
            // 2D Multidimensional Array of Car Names
            string[,] cars =
            {
                { "Toyota", "BMW", "Honda" },
                { "Audi", "Ford", "Volkswagen" },
                { "Mercedes", "Nissan", "Kia" }
            };

            // Loop through rows
            for (int row = 0; row < cars.GetLength(0); row++)
            {
                // Loop through columns
                for (int col = 0; col < cars.GetLength(1); col++)
                {
                    Console.Write(cars[row, col] + " ");
                }

                Console.WriteLine(); // Move to next row
            }
        }
    }
}
