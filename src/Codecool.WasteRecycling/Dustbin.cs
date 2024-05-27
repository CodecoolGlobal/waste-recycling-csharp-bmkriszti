using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using Codecool.WasteRecycling;


namespace Codecool.WasteRecycling
{
    public class Dustbin
    {
        private string Color { get;  }
        private List<Garbage> contents;

        public Dustbin(string acolor)
        {
            Color = acolor;
            contents = new List<Garbage>();
        }

    

        public void ThrowOutGarbage(Garbage garbage)
        {
            if (garbage is PaperGarbage papergarbage && !papergarbage.IsSqueezed|| garbage is PlasticGarbage plasticGarbage && !plasticGarbage.Cleaned)
            {
                throw new DustbinContentException(
                    "Only cleaned plastic or squeezed paper garbage can be thrown into the dustbin.");
            }

            contents.Add(garbage);
        }

        private int CountGarbage(Func<Garbage, bool> filter)
        {
            int garbageCount = 0;

            foreach (var garbage in contents)
            {
                if (filter(garbage))
                {
                    garbageCount++;
                }

            }

            return garbageCount;
        }

        public int CountPlastic()
        {
            return CountGarbage(g => g is PlasticGarbage);
        }

        public int CountPaper()
        {
            return CountGarbage(g => g is PaperGarbage);
        }

        public int CountHouseWaste()
        {
            return CountGarbage(g => !(g is PaperGarbage) && !(g is PlasticGarbage));
        }

        public void ClearContents()
        {
            contents.Clear();
        }
        public override string ToString()
        {
            var groupedGarbage = contents.GroupBy(g => g.GetType().Name);

            string representation = $"{Color} Dustbin!\n";
            foreach (var group in groupedGarbage)
            {
                representation += $"{group.Key} content: {group.Count()} item(s)\n";
                foreach (var item in group)
                {
                    representation += $"{item}\n";
                }
            }

            return representation;
        }
        public void DisplayContents()
        {
            Console.WriteLine(ToString());
        }
    }
}
