using System;
using System.Collections.Generic;

class FindLongestSubsequence
{
    public static List<int> LongestSubsequence(List<int> list)
    {
        int currentNumber = list[0];
        int currentCount = 1;
        int bestNumber = list[0];
        int bestCount = 1;
        for (int i = 1; i < list.Count; i++)
        {
            if (list[i] == currentNumber)
            {
                currentCount++;
            }
            else
            {
                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                    bestNumber = currentNumber;
                }

                currentNumber = list[i];
                currentCount = 1;
            }
        }

        List<int> result = new List<int>();
        for (int i = 0; i < bestCount; i++)
        {
            result.Add(bestNumber);
        }

        return result;
    }
    static void Main()
    {
        List<int> list = new List<int>
        {
            1, 2, 3, 3, 3, 4, 4, 5, 5
        };
        List<int> longestSubsequence = LongestSubsequence(list);
        foreach (var item in longestSubsequence)
        {
            Console.Write(item + " ");
        }
    }
}