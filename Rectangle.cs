namespace FigureForge
{
    public class Rectangle : Shape
    {
        protected override int MainPointsCount => 4;
        public float Width { get; set; }
        public float Height { get; set; }
        protected override void FindShapeMainPoints()
        {
            MainPoints[0] = new PointF(Center.X - (Width / 2), Center.Y - (Height / 2)); // A
            MainPoints[1] = new PointF(Center.X - (Width / 2), Center.Y + (Height / 2)); // B
            MainPoints[2] = new PointF(Center.X + (Width / 2), Center.Y + (Height / 2)); // C
            MainPoints[3] = new PointF(Center.X + (Width / 2), Center.Y - (Height / 2)); // D
        }
        public override void InitializePointsAndSides()
        {
            FindShapeMainPoints();
            AddSides(new Line(MainPoints[0], MainPoints[1], Height, "Height"),
                new Line(MainPoints[1], MainPoints[2], Width, "Width"),
                new Line(MainPoints[2], MainPoints[3], Height, "Height"),
                new Line(MainPoints[3], MainPoints[0], Width, "Width"));
        }
        public Rectangle(PointF centerLocation, float height, float width, Color fillColor, Color borderColor, int shapeBorderThickness) : base(centerLocation, fillColor, borderColor, shapeBorderThickness)
        {
            Height = height;
            Width = width;
            InitializePointsAndSides();
        }

        public override bool ContainPoint(PointF point)
        {
            return (MainPoints[0].X <= point.X && point.X <= MainPoints[3].X) && (MainPoints[0].Y <= point.Y && point.Y <= MainPoints[1].Y);
        }

        public override void IncreaseSidesSizes(params float[] increments)
        {
            float widthIncrease = increments[0];
            float heightIncrease = increments[1];

            Width += widthIncrease;
            Height += heightIncrease;

            InitializePointsAndSides();
        }

        public override List<Line> GetMainSides()
        {
            return [Sides[0], Sides[1]];
        }
        public override void UpdateSidesSizes(List<float> newSizes)
        {
            float heightSize = newSizes[0];
            float widthSize = newSizes[1];

            if (heightSize != 0) Height = heightSize;
            if (widthSize != 0) Width = widthSize;

            InitializePointsAndSides();
        }
        public override Shape GetCopy()
        {
            return new Rectangle(Center, Height, Width, ShapeFillColor, ShapeBorderColor, ShapeBorderThickness);
        }
        public override float Area()
        {
            return Width * Height;
        }
    }
}
