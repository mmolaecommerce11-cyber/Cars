using System;

namespace Cars
{
    class Cars
    {
        static void Main(string[] args)
        {
            int[,] numbers ={ { 1, 4, 2 },{ 5,7,3} };

            int i = 0;

            while (i < 2)
            {
                int j = 0;
                 while (j < 3)
                {
                      Console.WriteLine(numbers[i, j] + " ");
                    j++;
                }
                 Console.WriteLine();
                i++;
            }
        }
    }
}