namespace FigureForge
{
    public abstract class AppAction
    {
        public string Name { get; protected set; } = "";
        public abstract void Do();
        public abstract void Undo();
    }
}
