using System;
using System.Collections.Generic;
using System.Linq;

class EveryElementCount
{
    static void Main()
    {
        List<int> numbers = new List<int>
        {
            3, 4, 4, 2, 3, 3, 4, 3, 2
        };

        int max = numbers.Max();
        int[] occurance = new int[max + 1];
        for (int i = 0; i < numbers.Count; i++)
        {
            occurance[numbers[i]]++;
        }

        for (int i = 0; i < occurance.Length; i++)
        {
            if (occurance[i] > 0)
            {
                Console.WriteLine("{0} -> {1} times", i, occurance[i]);
            }
        }
    }
}