using System.Runtime.CompilerServices;

namespace Codecool.WasteRecycling
{
    public class PlasticGarbage : Garbage
    {
        public bool Cleaned { get; private set; }

        public PlasticGarbage(string name, bool cleaned) : base(name)
        {
            Cleaned = cleaned;
        }

        public void Clean()
        {
            if (!Cleaned)
            {
                Cleaned = true;
            }
        }
    }
}
