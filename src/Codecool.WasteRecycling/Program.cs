namespace Codecool.WasteRecycling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dustbin szemetes = new Dustbin("red");

            Garbage newspaper = new PaperGarbage("Newspaper", false);
            Garbage plasticBottle = new PlasticGarbage("Plastic bottle", true);

            if (newspaper is PaperGarbage)
            {
                ((PaperGarbage)newspaper).Squeeze();
            }
            szemetes.ThrowOutGarbage(newspaper);
            szemetes.ThrowOutGarbage(plasticBottle);
            
            szemetes.DisplayContents();

            
        }
    }
}
