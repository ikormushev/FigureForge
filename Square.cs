namespace FigureForge
{
    internal class Square: Shape
    {
        protected override int MainPointsCount => 4;
        public float MainSide { get; set; }

        protected override void FindShapeMainPoints()
        {
            MainPoints[0] = new PointF(Center.X - (MainSide / 2), Center.Y - (MainSide / 2));
            MainPoints[1] = new PointF(Center.X - (MainSide / 2), Center.Y + (MainSide / 2));
            MainPoints[2] = new PointF(Center.X + (MainSide / 2), Center.Y + (MainSide / 2));
            MainPoints[3] = new PointF(Center.X + (MainSide / 2), Center.Y - (MainSide / 2));
        }

        public override void InitializePointsAndSides()
        {
            FindShapeMainPoints();
            AddSides(new Line(MainPoints[0], MainPoints[1], MainSide),
                new Line(MainPoints[1], MainPoints[2], MainSide),
                new Line(MainPoints[2], MainPoints[3], MainSide),
                new Line(MainPoints[3], MainPoints[0], MainSide));
        }

        public Square(PointF centerLocation, float side, Color fillColor, Color borderColor, int shapeBorderThickness) : base(centerLocation, fillColor, borderColor, shapeBorderThickness)
        {
            MainSide = side;
            InitializePointsAndSides();
        }

        public override bool ContainPoint(PointF point)
        {
            return (MainPoints[0].X <= point.X && point.X <= MainPoints[3].X) && (MainPoints[0].Y <= point.Y && point.Y <= MainPoints[1].Y);
        }

        public override void IncreaseSidesSizes(params float[] increments)
        {
            MainSide += increments[0];
            InitializePointsAndSides();
        }

        public override void UpdateSidesSizes(List<float> newSizes)
        {
           MainSide = newSizes[0];
            InitializePointsAndSides();
        }

        public override Shape GetCopy()
        {
            return new Square(Center, MainSide, ShapeFillColor, ShapeBorderColor, ShapeBorderThickness);
        }
        public override float Area()
        {
            return MainSide * MainSide;
        }
    }
}
