using System;

public class Queue<T>
{
    public class QueueNode
    {
        public T Value { get; set; }
        public QueueNode Next { get; set; }
        public QueueNode(T value)
        {
            this.Value = value;
            this.Next = null;
        }
    }

    public QueueNode Head { get; set; }
    public QueueNode Tail { get; set; }
    public int Count { get; set; }
    public Queue()
    {
        this.Head = null;
        this.Tail = null;
        this.Count = 0;
    }
    public bool isEmpty()
    {
        return this.Head == null && this.Tail == null;
    }
    public void Enqueue(T value)
    {
        if (isEmpty())
        {
            this.Head = new QueueNode(value);
            this.Tail = this.Head;
        }
        else
        {
            QueueNode newNode = new QueueNode(value);
            this.Tail.Next = newNode;
            this.Tail = newNode;
        }

        Count++;
    }
    public T Dequeue()
    {
        if (isEmpty())
        {
            throw new InvalidOperationException("Queue is empty");
        }

        T value = this.Head.Value;
        if (this.Head == this.Tail)
        {
            this.Head = null;
            this.Tail = null;
        }
        else
        {
            this.Head = this.Head.Next;
        }

        Count--;
        return value;
    }
    public override string ToString()
    {
        string result = string.Empty;
        var currentElement = this.Head;
        while (currentElement != null)
        {
            result += currentElement.Value + " ";
            currentElement = currentElement.Next;
        }

        return result;
    }
}

class TestQueue
{
    static void Main()
    {
        Queue<int> q = new Queue<int>();
        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(3);
        q.Enqueue(4);
        Console.WriteLine(q.Dequeue());
        Console.WriteLine(q.ToString());
    }
}