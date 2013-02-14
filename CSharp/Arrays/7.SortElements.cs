/* Sorting an array means to arrange its elements in increasing order.
  Write a program to sort an array. Use the "selection sort" algorithm:
  Find the smallest element, move it at the first position, find the smallest from the
  rest, move it at the second position, etc.
 */

using System;

class SelectSort
{
    static void Main()
    {
        int[] myArray = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 11, 121, 45, -2, 118 };
        for (int i = 0; i < myArray.Length; i++)
        {
            for (int j = i + 1; j < myArray.Length; j++)
            {
                if (myArray[i] > myArray[j])
                {
                    int temp = 0;
                    temp = myArray[i];
                    myArray[i] = myArray[j];
                    myArray[j] = temp;
                }
            }
        }
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write("{0}, ", myArray[i]);
        }
        Console.WriteLine();
    }
}