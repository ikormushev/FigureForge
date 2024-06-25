namespace FigureForge
{
    internal class Triangle : Shape
    {
        protected override int MainPointsCount => 3;
        public float MainSide { get; set; }
        private float Height { get; set; }

        protected override void FindShapeMainPoints()
        {
            PointF centerPointAB = new(Center.X, Center.Y + (Height * 1 / 3));
            MainPoints[0] = new PointF(centerPointAB.X - (MainSide / 2), centerPointAB.Y); // A
            MainPoints[1] = new PointF(centerPointAB.X + (MainSide / 2), centerPointAB.Y); // B   
            MainPoints[2] = new PointF(Center.X, Center.Y - (Height * 2 / 3)); // C  
        }

        public override void InitializePointsAndSides()
        {
            FindHeight();
            FindShapeMainPoints();
            AddSides(new Line(MainPoints[0], MainPoints[1], MainSide),
                new Line(MainPoints[1], MainPoints[2], MainSide),
                new Line(MainPoints[2], MainPoints[0], MainSide));
        }

        public Triangle(PointF centerLocation, float side, Color fillColor, Color borderColor, int shapeBorderThickness) : base(centerLocation, fillColor, borderColor, shapeBorderThickness)
        {
            MainSide = side;
            InitializePointsAndSides();
        }

        public void FindHeight() => Height = MainSide * (float)(Math.Sqrt(3) / 2);

        public override bool ContainPoint(PointF point)
        {
            PointF A = MainPoints[0], B = MainPoints[1], C = MainPoints[2];

            if (point.X < A.X || point.Y > A.Y || point.X > B.X || point.Y < C.Y) return false;

            float determinant = (B.Y -  C.Y) * (A.X - C.X) + (C.X - B.X) * (A.Y - C.Y); // this is also called the area of ABC triangle
            float alpha = ((B.Y - C.Y) * (point.X - C.X) + (C.X - B.X) * (point.Y - C.Y)) / determinant;
            float beta = ((C.Y - A.Y) * (point.X - C.X) + (A.X - C.X) * (point.Y - C.Y)) / determinant;
            float gamma = 1 - alpha - beta;

            bool is_alpha_valid = 0 <= alpha && alpha <= 1;
            bool is_beta_valid = 0 <= beta && beta <= 1;
            bool is_gamma_valid = 0 <= gamma && gamma <= 1;

            return is_alpha_valid && is_beta_valid && is_gamma_valid;
        }

        public override void IncreaseSidesSizes(params float[] increments)
        {
            MainSide += increments[0];
            InitializePointsAndSides();
        }

        public override Shape GetGlowShape()
        {
            return new Triangle(Center, MainSide + (ShapeBorderThickness * 1.66f), Color.Empty, Color.Empty, 2);
        }

        public override void UpdateSidesSizes(List<float> newSizes)
        {
            MainSide = newSizes[0];
            InitializePointsAndSides();
        }

        public override Shape GetCopy()
        {
            return new Triangle(Center, MainSide, ShapeFillColor, ShapeBorderColor, ShapeBorderThickness);
        }
        public override float Area()
        {
            return MainSide * Height * 1 / 2;
        }
    }
}
