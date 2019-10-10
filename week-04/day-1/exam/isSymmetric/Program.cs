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
            int[,] array =
                {
                    { 1, 2, 3},
                    { 2, 3, 2},
                    { 3, 2, 1}
                };

            Console.WriteLine(IsSymetric(array));

            Console.ReadKey();

        }

        public static bool IsSymetric(int[,] array)
        {

                for (int y = 0; y < array.GetLength(0); y++)
                {
                    if (array[0, y] != array[y, 0] || array[y, array.GetLength(0) - 1] != array[array.GetLength(0) - 1, y])
                    {
                        return false;
                    }
                }
            
            return true;
        }

    }
}
