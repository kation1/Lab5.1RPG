using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1RPG
{

    class Wizard : MagicUsingCharacter
    {
        public int spellNumber { get; protected set; }
        public Wizard(string thename, int thestrength, int theintelligence, int themagicalEnergy, int thespellNumber) : base(thename, thestrength, theintelligence, themagicalEnergy)
        {
            spellNumber = thespellNumber;

        }
         public override void Play()
        {
            base.Play();
            Console.WriteLine($"Spell Number:{spellNumber}");
        }
    }

}
