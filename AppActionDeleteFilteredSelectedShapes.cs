namespace FigureForge
{
    public class AppActionDeleteFilteredSelectedShapes : AppAction
    {
        private List<Shape> mainShapes;
        private List<Shape> previousMainShapes;
        private List<Shape> filteredShapes;
        
        public AppActionDeleteFilteredSelectedShapes(List<Shape> _mainShapes, List<Shape> _filteredShapes) 
        { 
            mainShapes = _mainShapes;
            previousMainShapes = new(_mainShapes);
            filteredShapes = new(_filteredShapes);

            Name = "Selected shapes deleted";
        }

        public override void Do()
        {
            mainShapes.RemoveAll(x => filteredShapes.Contains(x));
        }

        public override void Undo()
        {
            mainShapes.Clear();
            mainShapes.AddRange(previousMainShapes);
        }
    }
}
