namespace FigureForge
{
    public class Line
    {
        public float Length { get; private set; }
        public PointF StartPoint { get; private set; }
        public PointF EndPoint { get; private set; }
        public string Name { get; private set; } = "Side";

        public Line(PointF start, PointF end)
        {
            StartPoint = start;
            EndPoint = end;
            Length = (float)Math.Sqrt(
                Math.Pow(EndPoint.X - StartPoint.X, 2) +
                Math.Pow(EndPoint.Y - StartPoint.Y, 2));
        }

        public Line(PointF start, PointF end,  string name)
        {
            StartPoint = start;
            EndPoint = end;
            Name = name;
            Length = (float)Math.Sqrt(
                Math.Pow(EndPoint.X - StartPoint.X, 2) +
                Math.Pow(EndPoint.Y - StartPoint.Y, 2));
        }

        public Line(PointF start, PointF end, float length)
        {
            StartPoint = start;
            EndPoint = end;
            Length = length;
        }

        public Line(PointF start, PointF end, float length, string name)
        {
            StartPoint = start;
            EndPoint = end;
            Length = length;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name} - Start: ({StartPoint.X};{StartPoint.Y}) - End: ({EndPoint.X};{EndPoint.Y}) - Length: {Length}";
        }
    }
}
