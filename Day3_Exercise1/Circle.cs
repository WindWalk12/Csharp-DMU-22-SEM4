using System.Drawing;

namespace Day3_Exercise1
{
    public class Circle: Shape
    {
        private double radius;

        public Circle(double x, double y, double radius): base(x,y)
        {
            this.radius = radius;
        }

        public double Radius { get { return radius; } set { radius = value; } }

        public override double Area()
        {
            return Math.PI * radius*radius;
        }

        public Point getCenter()
        {
            return new Point((int)(X + radius), (int)(Y + radius));
        }
    }
}
