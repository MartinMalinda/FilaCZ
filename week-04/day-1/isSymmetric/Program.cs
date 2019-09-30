using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isSymmetric
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] array = new int[3, 3];

            IsSymmetric(array, 3, 3);


            Console.ReadLine();

        }

        public static void IsSymmetric(int[,] newArray, int x, int y)
        {
            int[,] array = new int[x, y];

            for (int row = 0; row < array.Length / x; row++)
            {

                for (int column = 0; column < array.Length / y; column++)
                {
                    bool sameCoordinates = row == column;
                    if (sameCoordinates)
                    {
                        array[row, column] = 1;
                    }
                    Console.Write(array[row, column]);
                    Console.Write(" ");

                }
                Console.Write("\n");
            }
        }
    }
}
