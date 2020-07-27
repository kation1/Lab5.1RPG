using System;
using System.Collections.Generic;

namespace Lab5._1RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Word of Dev.Build!");
            List<GameCharacter> players = new List<GameCharacter>();
            players.Add(new Warrior("Bareris", 17, 9, "sword"));
            players.Add(new Wizard("Farideh", 8, 16, 5, 6));
            players.Add(new Wizard("Adrotrix", 6, 17,6,8));
            players.Add(new Warrior("Silverfury", 16, 5, "club"));
            players.Add(new Warrior("Deathshadow", 17, 4, "mace"));
            players.Add(new Wizard("Itarum", 5, 19, 4, 4));

            for (int i = 0; i < players.Count; i++)
            {
                 players[i].Play();
            }
           
        }
    }
}
