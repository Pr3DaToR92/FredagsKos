using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredagsKos.Characters
{
    internal class Character
    {
        private string _characterName;
        private int _characterAge;
        private string _characterJob;
        private int _characterEnergy;
        public Character(string characterName, int characterAge, string characterJob, int characterEnergy)
        {
            _characterName = characterName;
            _characterAge = characterAge;
            _characterJob = characterJob;
            _characterEnergy = characterEnergy;
        }
        public void CharInfo()
        {
            Console.WriteLine($"Name: {_characterName}, Age: {_characterAge}, Job: {_characterJob}, Energy: {_characterEnergy}");
        }





    }
    
}