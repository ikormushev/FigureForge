namespace FigureForge
{
    public class AppActionShapeDelete : AppActionShape
    {
        private int ShapeIndex;
        private List<Shape> givenShapes;

        public AppActionShapeDelete(List<Shape> modifiedShapes, Shape shapeAdded) : base(shapeAdded)
        {
            givenShapes = modifiedShapes;
            ShapeIndex = givenShapes.IndexOf(shapeAdded);
            Name = $"{shapeAdded.GetType().Name} deleted";
        }

        public override void Do() => givenShapes.Remove(ShapeAdded);

        public override void Undo() => givenShapes.Insert(ShapeIndex, ShapeAdded);

    }
}
