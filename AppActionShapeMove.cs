namespace FigureForge
{
    public class AppActionShapeMove : AppActionShape
    {
        private PointF startingShapeCenter;
        private PointF newMousePoint;
        private PointF undoCenterPoint;

        public AppActionShapeMove(Shape shapeAdded, PointF centerPoint, PointF previousMouseP, PointF newMouseP) : base(shapeAdded)
        {
            startingShapeCenter = shapeAdded.Center;
            undoCenterPoint = centerPoint;
            newMousePoint = new PointF(newMouseP.X - previousMouseP.X, newMouseP.Y - previousMouseP.Y);
            Name = $"{shapeAdded.GetType().Name} moved position";
        }

        public override void Do()
        {
            ShapeAdded.Center = new PointF(startingShapeCenter.X + newMousePoint.X, startingShapeCenter.Y + newMousePoint.Y);
            ShapeAdded.InitializePointsAndSides();
        }

        public override void Undo()
        {
            ShapeAdded.Center = undoCenterPoint;
            ShapeAdded.InitializePointsAndSides();
        }
    }
}
