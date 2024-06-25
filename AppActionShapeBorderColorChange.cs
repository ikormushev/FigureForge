namespace FigureForge
{
    public class AppActionShapeBorderColorChange : AppActionShape
    {
        private Color previousBorderColor;
        private Color newBorderColor;

        public AppActionShapeBorderColorChange(Shape shapeAdded, Color newGivenBorderColor) : base(shapeAdded)
        {
            previousBorderColor = shapeAdded.ShapeBorderColor;
            newBorderColor = newGivenBorderColor;
            Name = $"{shapeAdded.GetType().Name} border color changed";
        }

        public override void Do()
        {
            ShapeAdded.ShapeBorderColor = newBorderColor;
        }

        public override void Undo()
        {
            ShapeAdded.ShapeBorderColor = previousBorderColor;
        }
    }
}
