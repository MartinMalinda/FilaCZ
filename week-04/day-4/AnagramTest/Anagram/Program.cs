using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public bool IsAnagram(string wordOne, string wordTwo)
        {

            char[] wordOneArray = wordOne.ToCharArray();
            char[] wordTwoArray = wordTwo.ToCharArray();
            List<char> wordOneList = wordOneArray.ToList();
            List<char> wordTwoList = wordTwoArray.ToList();

            for (int i = 0; i < wordOneArray.Count(); i++)
            {
                if (wordOneArray[i] == wordTwoArray[i])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
