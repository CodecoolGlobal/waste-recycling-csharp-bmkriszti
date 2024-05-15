using System.Dynamic;

namespace Codecool.WasteRecycling
{
    public class PlasticGarbage : Garbage
    {
    
    public bool IsClean { get; private set; }
    
        public PlasticGarbage (string name, bool isClean) : base(name)
        {
            IsClean = isClean;
        }

        public void Clean()
        {
            if (!IsClean)
            {
                IsClean=true;
            }
        }
    }
}
