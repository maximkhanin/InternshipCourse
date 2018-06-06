using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = Engine.Dohci4;
            var color = Color.Azure;
            var transmission = Transmission.ManualTransmission;

            var car = CarConstructor.Construct(engine, color, transmission);
            Console.WriteLine(car);

            CarConstructor.Reconstruct(car, Engine.Dohcv6);
            Console.WriteLine(car);
        }
    }
}
