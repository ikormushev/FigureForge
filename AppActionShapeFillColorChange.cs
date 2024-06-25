namespace FigureForge
{
    public class AppActionShapeFillColorChange : AppActionShape
    {
        private Color previousFillColor;
        private Color newFillColor;

        public AppActionShapeFillColorChange(Shape shapeAdded, Color newFillColor) : base(shapeAdded)
        {
            previousFillColor = shapeAdded.ShapeFillColor;
            this.newFillColor = newFillColor;
            Name = $"{shapeAdded.GetType().Name} fill color changed";
        }

        public override void Do() => ShapeAdded.ShapeFillColor = newFillColor;

        public override void Undo() => ShapeAdded.ShapeFillColor = previousFillColor;
    }
}
