using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1RPG
{
    class MagicUsingCharacter : GameCharacter
    {
        public int magicalEnergy { get; protected set; }
        public MagicUsingCharacter(string thename, int thestrength, int theintelligence, int themagicalEnergy) : base(thename, thestrength, theintelligence)
        {
            magicalEnergy = themagicalEnergy;
        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Magical Energy:{magicalEnergy}");
        }
    }
}
