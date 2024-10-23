using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 5, 8, 6, 3, 4 };
        //List<int> mtx = new List<int>();
        List<int> ordderedNums = arr.Where(n => n % 2 != 0)  // Keep only odd numbers
                                     .OrderBy(n => n)         // Sort in ascending order
                                     .ToList();
        foreach (int item in ordderedNums)
            Console.Write($"Odd Numbers Are: {item} ");
        int r = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0)
            {
                arr[i] = ordderedNums[r];
                r++;

            }
        }
        Console.WriteLine();
        foreach (var item in arr)
        {
            Console.Write($"{item} ");
        }

    }

    public static int[] SortArray(int[] array)
    {

        return array;
    }


}