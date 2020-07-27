using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1RPG
{
    class GameCharacter
    {
        public string name { get; protected set; }
        public int strength { get; protected set; }
        public int intelligence { get; protected set; }

        public GameCharacter(string thename, int thestrength, int theintelligence)
        {
            name = thename;
            strength = thestrength;
            intelligence = theintelligence;
        }
        public virtual void Play()
        {
            Console.WriteLine($"\nName:{name}\nStrength: {strength}\nIntelligence:{intelligence}");
        }
    }
}
