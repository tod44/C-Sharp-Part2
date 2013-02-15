/* Write a program that reads two integer numbers N and K and an array
   of N elements from the console. Find in the array those K elements that have maximal sum.
 */

using System;

class MaximalSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] myArray = new int[n];
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = int.Parse(Console.ReadLine());
        }      
        int sum = 0;
        int bestSum = int.MinValue;
        int arrayLen = myArray.Length;
        for (int i = 0; i < arrayLen; i++)
        {
            // out of the array bounds
            if (i + k > arrayLen)
            {
                break;
            }
            // set check
            for (int j = i; j < i + k; j++)
            {
                sum = sum + myArray[j];
            }
            // best sum check
            if (sum > bestSum)
            {
                bestSum = sum;
            }
            sum = 0;
        }
        Console.WriteLine(bestSum);
    }
}