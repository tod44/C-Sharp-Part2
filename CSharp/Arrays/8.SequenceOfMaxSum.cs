using System;

class SequenceOfMaxSum
{
    static void Main()
    {
        int[] array = { 1, -2, 3, -4, 7, -1, 2, -3, 4 };
        int maxSum = int.MinValue;
        int sum = 0;
        int start = 0;
        int end = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            if (sum < 0)
            {
                sum = 0;
                start = i + 1;
            }

            if (sum > maxSum)
            {
                maxSum = sum;
                end = i;
            }
        }
        Console.WriteLine(maxSum);
        for (int i = start; i <= end; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}