namespace Codecool.WasteRecycling
{
    public class PaperGarbage : Garbage
    {
        public bool IsSqueezed { get; private set; }
        public PaperGarbage(string name, bool isSqueezed) : base(name)
        {
            IsSqueezed = isSqueezed;
        }

        public void Squeeze()
        {
            if (!IsSqueezed)
            {
                IsSqueezed = true;
            }
        }
    }
}
