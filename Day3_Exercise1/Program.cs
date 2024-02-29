namespace Day3_Exercise1;
internal class Program
{
    public static void Main()
    {
        List<Shape> shapesList = new List<Shape>();
        Circle circle1 = new Circle(2, 3, 10);
        Rectangle rect1 = new Rectangle(4, 5, 10, 15);

        shapesList.Add(circle1);
        shapesList.Add(rect1);

        foreach (Shape shape in shapesList)
        {
            Console.WriteLine(shape.X + " " + shape.Y);
            Console.WriteLine("Area: " + shape.Area());
        }
    }
}