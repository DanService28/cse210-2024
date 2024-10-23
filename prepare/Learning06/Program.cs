using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
    
        Square shape1 = new Square("Orange", 9);
        Rectangle shape2 = new Rectangle("Yellow", 12, 10);
        Circle shape3 = new Circle("Blue", 12.4);

        shapes.AddRange(new Shape[] {shape1, shape2, shape3});

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The shape color {color} has an area of {area}");
        }
    }
}