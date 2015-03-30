using System;
using System.Collections.Generic;

class PrintQueue
{
    static void Main()
    {
        Console.Write("N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int lastOfSequence = 50;
        int index = 1;
        Console.WriteLine(n + " ");
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(n);
        while (index < lastOfSequence)
        {
            int currentElement = queue.Dequeue();
            int first = currentElement + 1;
            queue.Enqueue(first);
            Console.Write(first + ", ");
            index++;
            if (index == lastOfSequence)
            {
                break;
            }

            int second = 2 * currentElement + 1;
            queue.Enqueue(second);
            Console.Write(second + ", ");
            index++;
            if (index == lastOfSequence)
            {
                break;
            }

            int third = currentElement + 2;
            queue.Enqueue(third);
            Console.Write(third + ", ");
            index++;
        }
    }
}