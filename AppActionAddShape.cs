namespace FigureForge
{
    public class AppActionAddShape : AppActionShape
    {
        private List<Shape> ModifiedShapes;

        public AppActionAddShape(List<Shape> shapes, Shape shapeAdded) : base(shapeAdded)
        {
            ModifiedShapes = shapes;
            Name = $"{shapeAdded.GetType().Name} created";
        }

        public override void Do() => ModifiedShapes.Add(ShapeAdded);
        public override void Undo() => ModifiedShapes.Remove(ShapeAdded);
    }
}
