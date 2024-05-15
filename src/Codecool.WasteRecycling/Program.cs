namespace Codecool.WasteRecycling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dustbin szemetes = new Dustbin("blue");


            
            Garbage plasticBag = new PlasticGarbage("Plastic bag", false);
            Garbage crumpledPaper = new PaperGarbage("Crumbled paper", true);
            
           
            
            if (plasticBag is PlasticGarbage)
            {
                ((PlasticGarbage)plasticBag).Clean();
            }
            szemetes.ThrowOutGarbage(plasticBag);
            szemetes.ThrowOutGarbage(crumpledPaper);
            
            szemetes.DisplayContents();
            
            szemetes.EmptyContents();
            
            szemetes.DisplayContents();
        }
    }
}
