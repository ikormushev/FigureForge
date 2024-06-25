namespace FigureForge
{
    public class AppActionShapePosition : AppActionShape
    {
        private List<Shape> ModifiedShapes;
        private string Movement;

        private int shapePreviousIndex;
        private int shapeNewIndex;
        private Shape temporaryShape;

        public AppActionShapePosition(List<Shape> shapes, Shape shapeAdded, string givenMovement) : base(shapeAdded)
        {
            ModifiedShapes = shapes;
            Movement = givenMovement;
            Name = $"{shapeAdded.GetType().Name} changed layer - {Movement}";
        }

        public override void Do()
        {
            shapePreviousIndex = ModifiedShapes.IndexOf(ShapeAdded);
            if (Movement == "UP") shapeNewIndex = shapePreviousIndex + 1;
            else if (Movement == "DOWN") shapeNewIndex = shapePreviousIndex - 1;
            temporaryShape = ModifiedShapes[shapeNewIndex];

            ModifiedShapes[shapePreviousIndex] = temporaryShape;
            ModifiedShapes[shapeNewIndex] = ShapeAdded;
        }

        public override void Undo()
        {
            ModifiedShapes[shapePreviousIndex] = ShapeAdded;
            ModifiedShapes[shapeNewIndex] = temporaryShape;
        }
    }
}
