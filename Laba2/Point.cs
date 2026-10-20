internal class Point
{
    private double x;
    private double y;

    //public Point()
    //{
    //    x = 0; y = 0;
    //}

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    //public Point(Point point)
    //{
    //    this.x = point.x;
    //    this.y = point.y;
    //}

    public double X
    {
        get { return x; }
        set { x = value; }
    }

    public double Y
    {
        get { return y; }
        set { y = value; }
    }

    public override string ToString()
    {
        string s = "{" + x + ";" + y + "}";
        return s;
    }
}