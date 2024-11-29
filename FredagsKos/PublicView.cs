using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FredagsKos.Characters;
namespace FredagsKos
{
    internal class PublicView
    {
        public PublicView()
        {
            CreateCharacter.NewCharacter();
        }

        public void MakeYourCharacter()
        {
            Console.WriteLine("Skriv inn ditt karakter navn: ");
            string name = Console.ReadLine();

            var IsCharacterDone = false;

            switch (IsCharacterDone)
            {

            }

        }
    }
}