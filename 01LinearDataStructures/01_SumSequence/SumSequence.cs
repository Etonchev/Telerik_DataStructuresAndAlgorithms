using System;
using System.Collections.Generic;

class SumSequence
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input != "")
            {
                numbers.Add(Convert.ToInt32(input));
            }
            else
            {
                break;
            }
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        double average = sum / numbers.Count;
        Console.WriteLine("Sum: {0}", sum);
        Console.WriteLine("Average: {0}", average);
    }
}