using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            var node = new Node<int>(1);
            var node1 = new Node<int>(2);
            var node2 = new Node<int>(3);
            var node3 = new Node<int>(4);

            var doublyLinkedList = new DoublyLinkedList<int>();
            doublyLinkedList.AddEnd(node1);
            doublyLinkedList.AddEnd(node2);
            doublyLinkedList.AddEnd(node3);
            doublyLinkedList.AddEnd(node);

            Console.WriteLine(doublyLinkedList.IsExist(node2));
            Console.WriteLine(doublyLinkedList.IsExist(node));
           
            var nodes = doublyLinkedList.ToArray();

            foreach (var item in nodes)
            {
                Console.WriteLine("{0} ", item);
            }

        }
    }
}
