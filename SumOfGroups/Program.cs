using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class AnagramSumSolution
{
    public static int SumOfDigitGroups(BigInteger[] numbers)
    {
        Dictionary<string, List<BigInteger>> groups = new(); // Use a dictionary to group by digit frequency

        foreach (var num in numbers)
        {
            string sortedDigits = GetDigitFrequencyKey(num.ToString()); // Get frequency key
            if (!groups.ContainsKey(sortedDigits))
            {
                groups[sortedDigits] = new List<BigInteger>();
            }
            groups[sortedDigits].Add(num); // Add number to the corresponding group
        }

        BigInteger sumOfMinNums = 0; // BigInteger to avoid overflow

        // Find the smallest number in each group (only if group has more than 1 number)
        foreach (var group in groups.Values)
        {
            if (group.Count > 1)
            {
                sumOfMinNums += group.Min();
            }
        }

        // Calculate the sum of digits of sumOfMinNums
        int sumOfDigits = sumOfMinNums.ToString().Select(digit => int.Parse(digit.ToString())).Sum();

        return sumOfDigits;
    }

    // Create a key representing the frequency of digits (for grouping)
    private static string GetDigitFrequencyKey(string num)
    {
        int[] freq = new int[10]; // Array to store frequency of digits 0-9

        foreach (var digit in num)
        {
            freq[digit - '0']++; // Increment the frequency of the corresponding digit
        }

        return string.Join(",", freq); // Return a string key representing the frequency array
    }
}