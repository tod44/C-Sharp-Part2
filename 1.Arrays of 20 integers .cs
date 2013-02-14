﻿/* Write a program that allocates array of 20 integers and initializes each element
   by its index multiplied by 5. Print the obtained array on the console.
 */

using System;

class SimpleArray
{
    static void Main()
    {
        int[] indexArray = new int[20];
        for (int i = 0; i < indexArray.Length; i++)
        {
            indexArray[i] = i * 5;       
            Console.Write(indexArray[i] + ",");
        }
        Console.WriteLine();
    }
}