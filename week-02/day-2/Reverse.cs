using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        public static string Reverse(string input)
        {
            /*char[] strArray = input.ToCharArray();
             char temp = ' ';
             for (int indexNumber = 0; indexNumber < strArray.Length / 2; indexNumber++) 
             {
                 temp = strArray[indexNumber]; 
                 strArray[indexNumber] = strArray[strArray.Length - 1 - indexNumber];
                 strArray[strArray.Length - 1 - indexNumber] = temp;
             }
             String whatever = new String(strArray);
             return whatever;
             */
            StringBuilder reversedInput = new StringBuilder(input); // StringBuilder will rewrite its value
            char temp = ' ';
            for (int indexNumber = 0; indexNumber < reversedInput.Length / 2; indexNumber++)
            {
                temp = reversedInput[indexNumber];
                reversedInput[indexNumber] = reversedInput[reversedInput.Length - 1 - indexNumber];
                reversedInput[reversedInput.Length - 1 - indexNumber] = temp;
            }

            return reversedInput.ToString(); // slovo is rewrited value of input str
        }
        static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Console.WriteLine(Reverse(reversed));
           
        }
    }
}
