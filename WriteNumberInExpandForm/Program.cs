using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class Program
{
   
    public static void Main(string[] args)

    {
       
    }
    //---
    public static string ExpandedForm(long num)
    {
        string numStr = num.ToString();
        List<string> lst = new();
        for (int i = 0; i < numStr.Length; i++)
        {
            if (numStr[i] != '0')
            {
                string temp = numStr[i].ToString();
                if (i < numStr.Length - 1)
                {
                    for (int j = i + 1; j < numStr.Length; j++)
                    {
                        if (numStr[j] != '0')
                        {
                            temp += numStr[j].ToString().Replace(Convert.ToChar(numStr[j]), '0');
                        }
                        else
                        {
                            temp += numStr[j].ToString();
                        }
                    }
                }
                lst.Add(temp);
            }
        }
        return string.Join(" + ", lst);
    }
  
  

}