namespace HW2
{
    public enum TransmissionEnum
    {
        ManualTransmission,
        FullyAutomaticTransmission,
        SemiAutomaticTransmission,
        ContinuouslyVariableTransmission
    }
    class Transmission
    {
        public TransmissionEnum TransmissionProperty { get; private set; }

        public Transmission(TransmissionEnum transmission)
        {
            TransmissionProperty = transmission;
        }

        public override string ToString()
        {
            return TransmissionProperty.ToString();
        }
    }
}
