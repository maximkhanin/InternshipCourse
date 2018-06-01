namespace HW2
{
    enum EngineEnum
    {
        Dohcv6,
        Dohci6,
        Dohci4,
        Dohcv8,
        SynchronousElectricMotor,
        Dohci4Turbodiesel,
        TurbochargedDohci6
    }
    class Engine
    {
        public EngineEnum EngineProperty { get; private set; }

        public Engine(EngineEnum engine)
        {
            EngineProperty = engine;
        }

        public override string ToString()
        {
            return EngineProperty.ToString();
        }
    }
}
