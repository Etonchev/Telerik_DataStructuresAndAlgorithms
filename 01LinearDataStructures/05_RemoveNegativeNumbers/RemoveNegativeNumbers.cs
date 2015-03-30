using System;
using System.Collections.Generic;

class RemoveNegativeNumbers
{
    static void Main()
    {
        List<int> positiveNumbers = new List<int>
        {
            1, -2, 3, -4, 5, -6, 7, -8, 9, -10
        };
        //for (int i = 0; i < positiveNumbers.Count; i++)
        //{
        //    if (positiveNumbers[i] < 0)
        //    {
        //        positiveNumbers.RemoveAt(i);
        //    }
        //}
        positiveNumbers.RemoveAll(x => x < 0);

        foreach (var item in positiveNumbers)
        {
            Console.Write(item + " ");
        }
    }
}