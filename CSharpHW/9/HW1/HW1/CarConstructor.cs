namespace HW1
{
    class CarConstructor
    {
        private CarConstructor()
        {

        }

        public static Car Construct(Engine engine, Color color, Transmission transmission)
        {
            return new Car
            {
                Engine = engine,
                Color = color,
                Transmission = transmission
            };
        }

        public static void Reconstruct(Car car, Engine engine)
        {
            car.Engine = engine;
        }
    }
}
