using System;
using System.Threading.Channels;

namespace Codecool.WasteRecycling
{
    public class DustbinContentException : Exception
    {
        public  DustbinContentException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
