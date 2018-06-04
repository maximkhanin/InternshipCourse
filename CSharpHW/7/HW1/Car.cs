namespace HW1
{
    class Car
    {
        public string Model { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }

        public Car(string model, string year, string color)
        {
            Model = model;
            Year = year;
            Color = color;
        }

        public override string ToString()
        {
            return "Model: " + Model + " Year: " + Year + " Color: " + Color + '\n';
        }
    }
}
