using System;

class Program
{
    static void Main()
    {
        int[,] A = {
            { -1, -2, -3 },
            { 4, -5, 6 },
            { 7, 8, -9 }
        };

        Console.WriteLine(FindFirstPositiveSumRow(A));
    }

    static int FindFirstPositiveSumRow(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
            if (sum > 0) return i;
        }
        return -1;
    }
}
