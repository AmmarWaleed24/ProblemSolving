using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class SumConsecutivesSolution
{
 public static int ConsecutiveSum(BigInteger[] arr)
    {
        // Remove duplicates and sort the array
        List<BigInteger> lst = new HashSet<BigInteger>(arr).OrderBy(x => x).ToList();
        
        BigInteger consecutiveSum = 0;
        BigInteger currentSequenceSum = 0;
        bool inSequence = false;

        for (int i = 0; i < lst.Count; i++)
        {
            if (i < lst.Count - 1 && lst[i + 1] - lst[i] == 1)
            {
                currentSequenceSum += lst[i];
                inSequence = true;
            }
            else
            {
                if (inSequence)
                {
                    currentSequenceSum += lst[i];
                    consecutiveSum += currentSequenceSum;
                    currentSequenceSum = 0;
                    inSequence = false;
                }
            }
        }

        // Calculate sum of digits of the total sum of consecutive numbers
        return SumOfDigits(consecutiveSum);
    }
   public static int SumOfDigits(BigInteger number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += (int)(number % 10);
            number /= 10;
        }
        return sum;
    }

}
  
