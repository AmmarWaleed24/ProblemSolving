using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int Solve(string input)
    {
        const string ALPHABETS = "abcdefghijklmnopqrstuvwxyz";
        const string VOWELS = "aeiou";
        List<int> results = new();
        int counter = 0;
        if (!string.IsNullOrEmpty(input))
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!VOWELS.Contains(input[i]))
                {
                    counter += ALPHABETS.IndexOf(input[i]) + 1;
                    if (i == input.Length - 1 && !VOWELS.Contains(input[i]))
                    {
                        results.Add(counter);

                    }
                }
                else
                {
                    if (counter > 0) results.Add(counter);
                    counter = 0;
                }

            }
            return results.Count > 0 ? results.Max() : 0;
        }
        return 0;
    }
}