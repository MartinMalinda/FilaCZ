using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output
            int[,] array = new int[4, 4];
            
            for (int row = 0; row < array.Length / 4; row++)
            {

                for (int column = 0; column < array.Length / 4; column++)
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


            Console.ReadLine();
        }
    }
}
