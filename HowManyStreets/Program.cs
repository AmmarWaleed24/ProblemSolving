// See https://aka.ms/n[[ew-console-template for more information
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Xml.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.IO;
using System.Collections;

namespace CSlearn;
class Program
{
    public static int[] CountStreets(string[] streets, string[][] drivers)
    {
        // Step 1: Map each street to its index for fast lookup
        Dictionary<string, int> streetIndex = new Dictionary<string, int>();
        for (int i = 0; i < streets.Length; i++)
        {
            streetIndex[streets[i]] = i;
        }

        // Step 2: Calculate the number of streets crossed for each driver
        int[] result = new int[drivers.Length];
        for (int i = 0; i < drivers.Length; i++)
        {
            string entryStreet = drivers[i][0];
            string exitStreet = drivers[i][1];

            int entryIndex = streetIndex[entryStreet];
            int exitIndex = streetIndex[exitStreet];

            // Step 3: Compute the number of streets crossed
            result[i] = Math.Abs(exitIndex - entryIndex) - 1;
        }

        return result;
    }
    static void Main(string[] arg)

    {

   
       
    }
 

}





