using System;

public class LinkedList<T>
{
    public class LinkedListNode
    {
        public T Value { get; set; }
        public LinkedListNode Next { get; set; }
        public LinkedListNode(T value)
        {
            this.Value = value;
            this.Next = null;
        }
        public LinkedListNode(T value, LinkedListNode previousNode)
        {
            this.Value = value;
            previousNode.Next = this;
        }
    }

    public LinkedListNode Head { get; set; }
    public LinkedListNode Tail { get; set; }
    public int Count { get; set; }
    public LinkedList()
    {
        this.Head = null;
        this.Tail = null;
        this.Count = 0;
    }
    public void AddLast(T value)
    {
        if (this.Head == null)
        {
            this.Head = new LinkedListNode(value);
            this.Tail = this.Head;
        }
        else
        {
            LinkedListNode newItem = new LinkedListNode(value, this.Tail);
            this.Tail = newItem;
        }
        this.Count++;
    }
    public T RemoveAt(int index)
    {
        if (index < 0 || index >= this.Count)
        {
            throw new IndexOutOfRangeException("Invalid index " + index);
        }

        Count--;
        T elementValue = default(T);

        if (Count == 0)
        {
            elementValue = this.Head.Value;
            this.Head = null;
            this.Tail = null;
        }

        if (index == 0 && Count != 0)
        {
            elementValue = this.Head.Value;
            LinkedListNode newHead = this.Head.Next;
            this.Head = newHead;
        }
        else
        {
            LinkedListNode currentElement = this.Head;
            for (int i = 0; i < index - 1; i++)
            {
                currentElement = currentElement.Next;
            }

            if (currentElement.Next == this.Tail)
            {
                this.Tail = currentElement;
            }
            else
            {
                this.Tail = currentElement.Next.Next;
            }

            elementValue = currentElement.Next.Value;
            currentElement.Next = currentElement.Next.Next;
        }

        return elementValue;
    }
    public void Print()
    {
        LinkedListNode currentElement = this.Head;
        for (int i = 0; i < this.Count; i++)
        {
            Console.Write("{0} ", currentElement.Value);
            currentElement = currentElement.Next;
        }
    }

}

class Test
{
    static void Main()
    {
        LinkedList<int> list = new LinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);
        list.Print();
        Console.WriteLine();
        Console.WriteLine(list.RemoveAt(2));
        list.Print();
        Console.WriteLine();
    }
}