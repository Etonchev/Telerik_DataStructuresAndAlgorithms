using System;

class Stack<T>
{
    public T[] StackArray { get; set; }
    public int Capacity { get; set; }
    public int Count { get; set; }
    public Stack()
    {
        Capacity = 4;
        StackArray = new T[Capacity];
        Count = 0;
    }
    public bool isEmpty()
    {
        return Count == 0;
    }
    public void DoubleCapacity()
    {
        Capacity *= 2;
        T[] oldStack = this.StackArray;
        this.StackArray = new T[Capacity];
        for (int i = 0; i < oldStack.Length; i++)
        {
            StackArray[i] = oldStack[i];
        }
    }
    public void Push(T value)
    {
        if (Count >= Capacity)
        {
            DoubleCapacity();
        }

        this.StackArray[Count] = value;
        Count++;
    }
    public T Pop()
    {
        if (isEmpty())
        {
            throw new InvalidOperationException("Stack is empty");
        }

        T element = StackArray[Count - 1];
        Count--;
        return element;
    }
    public void Print()
    {
        while (!isEmpty())
        {
            Console.WriteLine(Pop());
        }
    }
}

class TestStack
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Pop();
        stack.Print();
    }
}