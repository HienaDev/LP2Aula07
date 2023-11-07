using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Observers
{
    public class KeyReader : AbstractStringSubject
    {

       

        public void ReadKeys()
        {

            ConsoleKeyInfo cki;



            do
            {
                cki = Console.ReadKey(true);
                Item = cki.Key.ToString();
            } while (cki.Key != ConsoleKey.Escape);

        }
    }
}