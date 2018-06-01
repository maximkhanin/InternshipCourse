using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new Engine(EngineEnum.Dohci4);
            var color = new Color(ColorEnum.Gainsboro);
            var transmission = new Transmission(TransmissionEnum.ContinuouslyVariableTransmission);

            var car = CarConstructor.Construct(engine, color, transmission);
            Console.WriteLine(car);

            CarConstructor.Reconstruct(car, new Engine(EngineEnum.Dohci4Turbodiesel));
            Console.WriteLine(car);
        }
    }
}
