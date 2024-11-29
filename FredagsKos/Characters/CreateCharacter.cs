using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredagsKos.Characters
{
    internal class CreateCharacter
    {
        public static void NewCharacter()
        {
            Character _character;
            _character = new Character("Goodwall Tønnesen", 55, "Blacksmith", 45);
        }
    }
}
