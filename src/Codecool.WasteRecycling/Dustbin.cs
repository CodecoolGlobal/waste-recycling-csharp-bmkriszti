using System.Collections.Generic;
using System.Dynamic;
using System.Net.WebSockets;

namespace Codecool.WasteRecycling
{
    public class Dustbin
    {

        private readonly string color;
        private List<Garbage> contents;
        private readonly string message;


        public Dustbin(string color)
        {
            this.color = color;
            contents = new List<Garbage>();
            this.message = message;
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
            }
            else
            {
                throw new DustbinContentException("Only cleaned plastic or squeezed paper garbage can be thrown into the dustbin.");
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
            
        }
       
                
    }
}   

