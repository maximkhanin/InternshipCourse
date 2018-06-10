using System;

namespace HW1
{
    class Node<T>
    {
        public T Value { get; }
        public Node<T> Next;
        public Node<T> Prev;
        public Node(T value)
        {
            if (value == null)
            {
                throw new NullReferenceException();
            }
            
            Value = value;
        }
        public void Print()
        {
            Console.WriteLine(Value + " ");
        }
    }
}
