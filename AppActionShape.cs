namespace FigureForge
{
    public abstract class AppActionShape : AppAction
    {
        public Shape ShapeAdded { get; set; }
        public AppActionShape(Shape shapeAdded)
        {
            ShapeAdded = shapeAdded;
        }
    }
}
