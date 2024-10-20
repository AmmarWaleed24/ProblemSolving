// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
class Program
{
    public static int[] CountSubstr(string s, int p)
    {
        List<int> mylist = new();
        long divider = (long)Math.Pow(2, p);

        for (int i = 0; i < s.Length; i++)
        {
            int counter = 0;
            long number = 0;

            for (int j = i; j < s.Length; j++)
            {
                number = number * 10 + (s[j] - '0'); 

                if (number % divider == 0) counter++;
            }

            mylist.Add(counter);
        }

        return mylist.ToArray(); 
    }
    static void Main(string[] args)
    {
        
    }

}
