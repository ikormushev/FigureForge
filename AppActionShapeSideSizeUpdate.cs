namespace FigureForge
{
    public class AppActionShapeSideSizeUpdate : AppActionShape
    {
        private List<float> previousSizes = [];
        private List<float> newSizes = [];

        public AppActionShapeSideSizeUpdate(Shape shapeAdded, params float[] sizes) : base(shapeAdded)
        {
            Name = $"{shapeAdded.GetType().Name} size updated";

            foreach (Line side in shapeAdded.GetMainSides())
            {
                previousSizes.Add(side.Length);
            }

            foreach (float size in sizes)
            {
                newSizes.Add(size);
            }
        }

        public override void Do() => ShapeAdded.UpdateSidesSizes(newSizes);

        public override void Undo() => ShapeAdded.UpdateSidesSizes(previousSizes);
    }
}
