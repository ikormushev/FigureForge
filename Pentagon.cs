namespace FigureForge
{
    internal class Pentagon : Shape
    {
        protected override int MainPointsCount => 5;
        public float MainSide { get; set; }
        private float InnerRadius { get; set; } // apothem/height of each mini triangle
        private float OuterRadius { get; set; }

        private readonly float angleAroundCenterForEachTriangle = 72 * (float)(Math.PI / 180);

        protected override void FindShapeMainPoints()
        {
            float angle = angleAroundCenterForEachTriangle;
            float rotateAngle = (float)Math.PI / 2;
            for (int i = 0; i < 5; i++)
            {
                MainPoints[i] = new PointF((Center.X + (float)(OuterRadius * Math.Cos(i * angle - rotateAngle))),
                    (Center.Y + (float)(OuterRadius * Math.Sin(i * angle - rotateAngle))));
            }
        }
        public override void InitializePointsAndSides()
        {
            FindInnerOuterRadiuses();
            FindShapeMainPoints();
            AddSides(new Line(MainPoints[0], MainPoints[1], MainSide),
                new Line(MainPoints[1], MainPoints[2], MainSide),
                new Line(MainPoints[2], MainPoints[3], MainSide),
                new Line(MainPoints[3], MainPoints[4], MainSide),
                new Line(MainPoints[4], MainPoints[0], MainSide));
        }

        public Pentagon(PointF centerLocation, float side, Color fillColor, Color borderColor, int shapeBorderThickness) : base(centerLocation, fillColor, borderColor, shapeBorderThickness)
        {
            MainSide = side;
            InitializePointsAndSides();
        }

        public void FindInnerOuterRadiuses()
        {
            InnerRadius = MainSide / (float)(2 * Math.Tan(Math.PI / 5));
            OuterRadius = MainSide / (float)(2 * Math.Sin(Math.PI / 5));
        }

        public override bool ContainPoint(PointF point)
        {
            static bool IsPointInSmallTriangles(PointF F, PointF A, PointF B, PointF C)
            {
                float determinant = (B.Y - C.Y) * (A.X - C.X) + (C.X - B.X) * (A.Y - C.Y);
                float alpha = ((B.Y - C.Y) * (F.X - C.X) + (C.X - B.X) * (F.Y - C.Y)) / determinant;
                float beta = ((C.Y - A.Y) * (F.X - C.X) + (A.X - C.X) * (F.Y - C.Y)) / determinant;
                float gamma = 1 - alpha - beta;

                bool is_alpha_valid = 0 <= alpha && alpha <= 1;
                bool is_beta_valid = 0 <= beta && beta <= 1;
                bool is_gamma_valid = 0 <= gamma && gamma <= 1;

                return is_alpha_valid && is_beta_valid && is_gamma_valid;
            }

            if (point.X == Center.X && point.Y == Center.Y) return true;

            for ( int i = 0; i < MainPoints.Length; i++)
            {
                if (i == MainPoints.Length - 1)
                {
                    if (IsPointInSmallTriangles(point, Center, MainPoints[0], MainPoints[i])) return true;
                } 
                else
                {
                    if (IsPointInSmallTriangles(point, Center, MainPoints[i], MainPoints[i + 1])) return true;
                }
            }

            return false;
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
            return new Pentagon(Center, MainSide, ShapeFillColor, ShapeBorderColor, ShapeBorderThickness);
        }

        public override float Area()
        {
            return (5 * MainSide * InnerRadius) / 2;
        }
    }
}

