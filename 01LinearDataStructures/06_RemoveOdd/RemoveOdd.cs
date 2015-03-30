using System;
using System.Collections.Generic;

class RemoveOdd
{
    static void Main()
    {
        List<int> list = new List<int>
        {
            4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2
        };
        for (int i = 0; i < list.Count; i++)
        {
            int currentElement = list[i];
            int currentElementCount = 0;

            for (int j = 0; j < list.Count; j++)
            {
                if (currentElement == list[j])
                {
                    currentElementCount++;
                }
            }

            if (currentElementCount % 2 != 0)
            {
                list.RemoveAll(x => x == currentElement);
                i = 0;
            }
            else
            {
                i++;
            }
        }

        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
    }
}