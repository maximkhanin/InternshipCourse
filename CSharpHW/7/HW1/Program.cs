using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Audi","1990","blue");
            Console.WriteLine(car);

            TuningAtelier.TuneCar(car);
            Console.WriteLine(car);
        }
    }
}
