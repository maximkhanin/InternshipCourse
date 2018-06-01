namespace HW2
{
    public enum ColorEnum
    {
        Aquamarine,
        Azure,
        BurlyWood,
        CadetBlue,
        Gainsboro,
        Gold,
        Gray,
        Khaki,
        LawnGreen,
        LightGreen,
        LightSkyBlue,
        Linen,
        MediumOrchid,
        MediumPurple,
        MistyRose,
        Olive,
        OliveDrab,
        Orange,
        OrangeRed,
        Orchid,
        PaleTurquoise,
        Peru,
        Pink,
        Plum,
        RoyalBlue,
        SandyBrown,
        SeaGreen,
        SteelBlue
    }
    class Color
    {
        public ColorEnum ColorProperty { get; private set; }

        public Color(ColorEnum color)
        {
            ColorProperty = color;
        }

        public override string ToString()
        {
            return ColorProperty.ToString();
        }
    }
}
