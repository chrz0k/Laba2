internal class Line
{
    private Point Start;
    private Point End;

    public Line()
    {
        Start = new Point();
        End = new Point();
    }

    public Line(double a, double b, double c, double d)
    {
        Start = new Point(a,b);
        End = new Point(c,d);
    }

    public Line(Point point1, Point point2)
    {
        Start = point1;
        End = point2;
    }

    public Line(Line line)
    {
        this.Start = line.Start;
        this.End = line.End;
    }

    public Point StartPoint
    {
        get { return Start; }
        set { Start = value; }
    }

    public Point EndPoint
    {
        get { return End; }
        set { End = value; }
    }

    public override string ToString()
    {
        string s = "Линия от " + Start + " до " + End;
        return s;
    }
}