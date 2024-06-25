namespace FigureForge
{
    public class AppActionShapePenThickness : AppActionShape
    {
        private int oldPenValue;
        private int newPenValue;

        public AppActionShapePenThickness(Shape shapeAdded, int penSize) : base(shapeAdded)
        {
            Name = $"{shapeAdded.GetType().Name} pen thickness updated";
            oldPenValue = shapeAdded.ShapeBorderThickness;
            newPenValue = penSize;
        }

        public override void Do() => ShapeAdded.ShapeBorderThickness = newPenValue;
        public override void Undo() => ShapeAdded.ShapeBorderThickness = oldPenValue;
    }
}
