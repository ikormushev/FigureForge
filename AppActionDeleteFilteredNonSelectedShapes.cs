namespace FigureForge
{
    public class AppActionDeleteFilteredNonSelectedShapes : AppAction
    {
        private List<Shape> mainShapes;
        private List<Shape> previousMainShapes;
        private List<Shape> filteredShapes;

        public AppActionDeleteFilteredNonSelectedShapes(List<Shape> _mainShapes, List<Shape> _filteredShapes)
        {
            mainShapes = _mainShapes;
            previousMainShapes = new(_mainShapes);
            filteredShapes = new(_filteredShapes);

            Name = "Non-selected shapes deleted";
        }

        public override void Do()
        {
            mainShapes.Clear();
            mainShapes.AddRange(filteredShapes);
        }

        public override void Undo()
        {
            mainShapes.Clear();
            mainShapes.AddRange(previousMainShapes);
        }

    }
}
