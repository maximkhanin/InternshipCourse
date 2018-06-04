namespace HW3
{
    class ShapeDescriptor
    {
        private readonly string _shapeType;

        private readonly Point[] _points;

        public ShapeDescriptor(Point point1)
        {
            _points = new[] { point1 };
            _shapeType = "Dot";
        }

        public ShapeDescriptor(Point point1, Point point2)
        {
            _points = new[] { point1, point2 };
            _shapeType = "Line";
        }

        public ShapeDescriptor(Point point1, Point point2, Point point3)
        {
            _points = new[] { point1, point2, point3 };
            _shapeType = "Triangle";
        }
        public ShapeDescriptor(Point point1, Point point2, Point point3, Point point4)
        {
            _points = new[] { point1, point2, point3, point4 };
            _shapeType = "Quadrangle";
        }

        public string GetShapeType()
        {
            return _shapeType;
        }

        public string GetDots()
        {
            var result = string.Empty;

            for (var i = 0; i < _points.Length; i++)
            {
                result += " Point " + (i + 1) + ": " + _points[i];
            }

            return result;
        }
    }
}
