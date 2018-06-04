using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            var point1 = new Point(100, 100);
            var point2 = new Point(100, 100);
            var point3 = new Point(100, 100);
            var shapeDescriptor1 = new ShapeDescriptor(point1, point2, point3);

            Console.WriteLine(shapeDescriptor1.GetDots());
            Console.WriteLine(shapeDescriptor1.GetShapeType());

            var point4 = new Point(100, 100);
            var shapeDescriptor2 = new ShapeDescriptor(point1, point2, point3, point4);

            Console.WriteLine(shapeDescriptor2.GetDots());
            Console.WriteLine(shapeDescriptor2.GetShapeType());
        }
    }
}
