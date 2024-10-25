using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class Program
{

    public static void Main(string[] args)

    {

        DuplicateEncode("recede");

    }
    //-----
    public static void DuplicateEncode(string word)
    {
        // recede 
        Dictionary<char, int> freq = new();
        foreach (char c in word)
        {
            if (!freq.ContainsKey(c))
            {
                freq[c] = 1;
            }
            else
            {
                freq[c] += 1; // Increment the count for subsequent occurrences
            }
        }
        foreach (var item in freq)
        {
            Console.Write($"{item.Key}: ");
            Console.WriteLine($"{item.Value}");
        }
        //return word;
    }
   
}