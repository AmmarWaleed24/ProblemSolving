using System;
using System.Collections.Generic;

public class Program
{
    public static int BlowCandles(string str)
    {
        // Convert the string to a list of integers
        List<int> candles = new List<int>();
        foreach (char c in str)
        {
            candles.Add(c - '0'); // Convert character to integer
        }

        int counter = 0; // Count the number of moves

        // Loop until all candles are extinguished
        while (candles.Count > 0)
        {
            // Remove leading zeroes (candles that are already extinguished)
            while (candles.Count > 0 && candles[0] == 0)
            {
                candles.RemoveAt(0); // Remove extinguished candle from the list
            }

            // If no candles left, break out of the loop
            if (candles.Count == 0) break;

            // Reduce the strength of up to the first 3 candles
            for (int i = 0; i < Math.Min(3, candles.Count); i++)
            {
                if (candles[i] > 0)
                {
                    candles[i] -= 1; // Reduce strength by 1
                }
            }

            counter++; // Increment the move counter
        }

        // Return the number of moves required
        return counter;
    }

    public static void Main(string[] args)
    {
        // Example usage:
        string input = "2113";
        int result = BlowCandles(input);
        Console.WriteLine($"Counter Reached {result}");
    }
}
