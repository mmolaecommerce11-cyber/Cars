using System;

namespace Cars;
    class Cars
    {
        static void Main(string[] args)
        {
            int[,] numbers = {{ 1, 4, 2 },{ 5,7,3} };

            int j = 0;

            while (j < numbers.Length)
            {
                Console.WriteLine(numbers[0 , j]);
                j++;
            }
        }
    }
