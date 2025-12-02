using System;

namespace Cars
{
    class Cars
    {
        static void Main(string[] args)
        {
            string[,] cars ={ { "Lamborghini", "Ferarri", "Bugatti" },{ "Benz", "Audi", "Toyota" },{ "Uno", "Golf", "1400" } };

            int i = 0;

            while (i < 3)
            {
                int j = 0;
                 while (j < 3)
                {
                      Console.WriteLine(cars[i, j] + " ");
                    j++;
                }
                 Console.WriteLine();
                i++;
            }
        }
    }
}