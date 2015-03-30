using System;
using System.Collections.Generic;

class SortList
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

        numbers.Sort();
        foreach (var item in numbers)
        {
            Console.WriteLine(item + " ");
        }
    }
}