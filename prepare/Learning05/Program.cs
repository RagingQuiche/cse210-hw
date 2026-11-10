using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = [];
        Circle circle = new Circle("red", 4);
        Square square = new Square("blue", 5);
        Rectangle rectangle = new Rectangle("green", 2, 7);
        shapeList.Add(circle);
        shapeList.Add(square);
        shapeList.Add(rectangle);

        foreach (Shape shape in shapeList)
        {
            Console.WriteLine(shape);
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}