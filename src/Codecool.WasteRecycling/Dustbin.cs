using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.WebSockets;

namespace Codecool.WasteRecycling
{
    public class Dustbin
    {

        private readonly string color;
        private List<Garbage> contents;



        public Dustbin(string color)
        {
            this.color = color;
            contents = new List<Garbage>();
        }

        public string Color
        {
            get { return color; }
        }

        public void ThrowOutGarbage(Garbage garbage)
        {
            if (garbage is PlasticGarbage || (garbage is PaperGarbage && ((PaperGarbage)garbage).IsSqueezed))
            {
                contents.Add(garbage);
                Console.WriteLine($"Thrown {garbage.Name} into the dustbin.");
            }
            else
            {
                throw new DustbinContentException(
                    "Only cleaned plastic or squeezed paper garbage can be thrown into the dustbin.");
            }
        }

        public int PlasticCount()
        {
            int count = 0;
            foreach (var garbage in contents)
            {
                if (garbage is PlasticGarbage)
                {
                    count++;
                }
            }

            return count;
        }

        public int PaperCount()
        {
            int count = 0;
            foreach (var garbage in contents)
            {
                if (garbage is PaperGarbage && ((PaperGarbage)garbage).IsSqueezed)
                {
                    count++;
                }
            }

            return count;
        }

        public int CountHouseWaste()
        {
            int count = 0;
            foreach (var garbage in contents)
            {
                if (!(garbage is PlasticGarbage) && !(garbage is PaperGarbage) && !((PaperGarbage)garbage).IsSqueezed)
                {
                    count++;
                }
            }

            return count;
        }
        public void EmptyContents()
        {
            contents.Clear();
        }

      
        public override string ToString()
        {
            var groupedGarbage = contents.GroupBy(g => g.GetType().Name);

            string representation = $"{color} Dustbin!\n";
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
