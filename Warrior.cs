using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1RPG
{
    class Warrior : GameCharacter
    {
        public string weaponType { get; set; }
        public Warrior(string thename, int thestrength, int theintelligence, string theweaponType) : base(thename, thestrength, theintelligence)
        {
            weaponType = theweaponType;

        }
        public override void Play()
        {
            //name = "John";
            base.Play();
            Console.WriteLine($"Weapon:{weaponType}");

        }


    }
}
