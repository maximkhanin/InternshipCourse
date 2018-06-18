using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary();
            MyQueue();
            MyStack();
        }

        private static void MyDictionary()
        {
            Console.WriteLine("My Dictionary");

            var myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(1, "value1");
            myDictionary.Add(2, "value2");
            myDictionary.Add(3, "value3");
            myDictionary.Add(3, "value1");
            myDictionary.Remove(2, "value2");
            Console.WriteLine(myDictionary);
        }

        private static void MyQueue()
        {
            Console.WriteLine("My Queue");

            var myQueue = new MyQueue<int>();

            myQueue.Enqueue(1);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Enqueue(5);
            myQueue.Enqueue(6);
            myQueue.Enqueue(7);
            myQueue.Enqueue(8);

            Console.WriteLine("Queue - {0}", myQueue);
            Console.WriteLine("Operation Dequeue - {0}", myQueue.Dequeue());
            Console.WriteLine("Operation Peek - {0}", myQueue.Peek());
            Console.WriteLine("Queue - {0}", myQueue);
            Console.WriteLine("Count - {0}", myQueue.Count());
        }

        private static void MyStack()
        {
            Console.WriteLine("My Stack");

            var myStack = new MyStack<int>();

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            myStack.Push(6);
            myStack.Push(7);
            myStack.Push(8);
            myStack.Push(9);

            Console.WriteLine("Pop operation - {0}", myStack.Pop());
            Console.WriteLine("Pick operation - {0}", myStack.Peek());
            Console.WriteLine(myStack);
        }
    }
}
