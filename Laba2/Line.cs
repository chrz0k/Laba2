namespace Laba2;

internal class Line
{
    private Point start;
    private Point end;

    public Line()
    {
        start = new Point(0, 0);
        end = new Point(0, 0);
    }

    public Line(double a, double b, double c, double d)
    {
        start = new Point(a, b);
        end = new Point(c, d);
    }

    public Line(Point point1, Point point2)
    {
        start = point1;
        end = point2;
    }

    public Line(Line line)
    {
        start = line.start;
        end = line.end;
    }

    public Point StartPoint
    {
        get { return start; }
        set { start = value; }
    }

    public Point EndPoint
    {
        get { return end; }
        set { end = value; }
    }

    public override string ToString()
    {
        string s = $"Линия от {start} до {end}";
        return s;
    }
}