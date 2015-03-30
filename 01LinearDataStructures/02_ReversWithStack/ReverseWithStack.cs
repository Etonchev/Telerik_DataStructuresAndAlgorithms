using System;
using System.Collections.Generic;

    class ReverseWithStack
    {
        static void Main()
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("stack[{0}] = ", i);
                int number = Convert.ToInt32(Console.ReadLine());
                numbers.Push(number);
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }