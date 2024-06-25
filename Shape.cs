namespace FigureForge
{
    public abstract class Shape
    {
        protected List<Line> Sides { get; } = [];
        protected PointF[] MainPoints { get; set; }
        protected abstract int MainPointsCount { get; }

        public Color ShapeFillColor { get; set; }
        public Color ShapeBorderColor { get; set; }
        public int ShapeBorderThickness { get; set; }
        public PointF Center { get; set; }

        public Shape(PointF centerPoint, Color shapeFillColor, Color shapeBorderColor, int shapeBorderThickness)
        {
            Center = centerPoint;
            MainPoints = new PointF[MainPointsCount];

            ShapeFillColor = shapeFillColor;
            ShapeBorderColor = shapeBorderColor;
            ShapeBorderThickness = shapeBorderThickness;
        }

        public void DrawOnMainStage(Graphics g)
        {
            if (ShapeBorderColor != Color.Empty)
            {
                Pen pen = new(ShapeBorderColor, ShapeBorderThickness);
                DrawBorder(g, pen);
            }

            if (ShapeFillColor != Color.Empty)
            {
                using (Brush brush = new SolidBrush(ShapeFillColor))
                {
                    g.FillPolygon(brush, MainPoints);
                }
            }
        }

        protected void DrawBorder(Graphics g, Pen pen)
        {
            g.DrawPolygon(pen, MainPoints);
            pen.Dispose();
        }

        public virtual Shape GetGlowShape()
        {
            Shape glowShape = GetCopy();
            glowShape.IncreaseSidesSizes(ShapeBorderThickness, ShapeBorderThickness);
            return glowShape;
        }
        public void SelectionShapeGlow(PaintEventArgs e)
        {
            Pen drawPen = new(Color.Blue, 2);

            Shape glowShape = GetGlowShape();
            glowShape.DrawBorder(e.Graphics, drawPen);
        }

        protected void AddSides(params Line[] sides)
        {
            Sides.Clear();
            foreach (Line side in sides)
            {
                Sides.Add(side);
            }
        }

        public virtual List<Line> GetMainSides()
        {
            return [Sides[0]];
        }
        public abstract void InitializePointsAndSides();
        protected abstract void FindShapeMainPoints();
        public abstract bool ContainPoint(PointF point);
        public abstract void IncreaseSidesSizes(params float[] increments);

        public abstract void UpdateSidesSizes(List<float> newSizes);

        public abstract Shape GetCopy();
        public abstract float Area();
    }
}
