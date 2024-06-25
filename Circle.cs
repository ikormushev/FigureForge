namespace FigureForge
{
    internal class Circle: Shape
    {
        protected override int MainPointsCount => 360;
        public float Radius { get; set; }

        protected override void FindShapeMainPoints()
        {
            for (int i = 0; i < 360; i++)
            {
                float currentAngle = i * (float)Math.PI / 180;
                float pointX = (float)(Center.X + Radius * Math.Cos(currentAngle));
                float pointY = (float)(Center.Y + Radius * Math.Sin(currentAngle));
                MainPoints[i] = new PointF(pointX, pointY);
            }
        }

        public override void InitializePointsAndSides()
        {
            FindShapeMainPoints();
            AddSides(new Line(Center, new PointF(Center.X + Radius, Center.Y), Radius, "Radius"));
        }

        public Circle(PointF centerLocation, float radius, Color fillColor, Color borderColor, int shapeBorderThickness) : base(centerLocation, fillColor, borderColor, shapeBorderThickness)
        {
            Radius = radius;
            InitializePointsAndSides();
        }

        public override bool ContainPoint(PointF point)
        {
            Line CenterToPoint = new(Center, point);
            return !(CenterToPoint.Length > Radius);
        }
        public override void IncreaseSidesSizes(params float[] increments)
        {
            Radius += increments[0];
            FindShapeMainPoints();
        }

        public override void UpdateSidesSizes(List<float> newSizes)
        {
            Radius = newSizes[0];
            InitializePointsAndSides();
        }

        public override Shape GetGlowShape()
        {
            return new Circle(Center, Radius * (1 + (ShapeBorderThickness / 100f)), Color.Empty, Color.Empty, 2);
        }

        public override Shape GetCopy()
        {
            return new Circle(Center, Radius, ShapeFillColor, ShapeBorderColor, ShapeBorderThickness);
        }

        public override float Area()
        {
            return (float)Math.PI * (Radius * Radius);
        }
    }
}
