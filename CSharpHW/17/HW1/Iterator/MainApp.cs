using System;

namespace Iterator
{
    class MainApp
    {
        static void Main()
        {
            var a = new ConcreteAggregate<string>
            {
                [0] = "Item A",
                [1] = "Item B",
                [2] = "Item C",
                [3] = "Item D"
            };

            var i = new ConcreteIterator<string>(a);

            Console.WriteLine("Iterating over collection:");

            var item = i.First();

            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }

            Console.ReadKey();
        }
    }
}