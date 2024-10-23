using System;
using System.Collections.Generic;

namespace CSlearn;
internal class Program
{

    private static void Main(string[] arg)
    {

     
    }

    public static int[] Parse(string data)
    {
        List<int> mylist = new();
        int counter = 0;

        foreach (char ch in data)
        {
            switch (ch)
            {
                case 'i':
                    counter += 1;
                    break;
                case 's':
                    counter *= counter;
                    break;
                case 'd':
                    counter -= 1;
                    break;
                case 'o':
                    mylist.Add(counter);
                    break;
            }
        }

        return mylist.ToArray();
    }
 

}




