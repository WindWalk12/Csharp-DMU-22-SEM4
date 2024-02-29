namespace Day3_Exercise1
{
    public class Rectangle: Shape
    {
        private double length, width;

        public Rectangle(double x, double y, double length, double width): base(x,y)
        {
            this.length = length;
            this.width = width;
        }

        public double Length { get { return Length; } set { length = value; } }
        public double Width { get { return Length; } set { width = value; } }

        public override double Area()
        {
            return length * width;
        }
    }
}
