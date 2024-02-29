namespace Day3_Exercise1;

public abstract class Shape
{
	private double x, y;
	public Shape(double x, double y)
	{
		this.x = x; this.y = y;
	}

    public Shape(): this(1,1)
    {
		
    }

    public double X { get { return x; } set {  x = value; } }
	public double Y { get { return y; } set { y = value; } }

	abstract public double Area();
}
