using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            var human1 = new Human(23, "Maxim");
            var human2 = new Human(23, "Maxim");
            Console.WriteLine("Equals of Human1 and Human2: {0}", Human.Equals(human1, human2));

            var human3 = new Human(3, "Maxim");
            var human4 = new Human(23, "Maxim");
            Console.WriteLine("Equals of Human3 and Human4: {0}", Human.Equals(human3, human4));
        }
    }
}
