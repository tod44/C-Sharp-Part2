/* Write a program that compares
   two char arrays lexicographically (letter by letter).
 */

using System;

class CharCompare
{
    static void Main()
    {
        char[] firstArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'i' };
        char[] secondArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
        bool areLexiEqual = true;
       
        if (firstArray.Length == secondArray.Length)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areLexiEqual = false;
                }
            }
            Console.WriteLine(areLexiEqual);
        }
        else
        {
            areLexiEqual = false;
            Console.WriteLine(areLexiEqual);
        }

    }
}