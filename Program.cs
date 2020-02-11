using System;
using System.Collections.Generic;

namespace Lab5._1RPG
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Wizard wizB = new Wizard("Brea", 95, 100, 10);
            Wizard wizL = new Wizard("Lucero", 90, 100, 15);

            Warrior warT = new Warrior("Tom", 75, 90, "Sword");
            Warrior warN = new Warrior("Nic", 50, 50, "Canon");
            Warrior warM = new Warrior("Mike", 65, 75, "Bow and Arrow");

            List<GameCharacter> gameCharacter = new List<GameCharacter>();
            gameCharacter.Add(wizB);
            gameCharacter.Add(wizL);

            gameCharacter.Add(warT);
            gameCharacter.Add(warN);
            gameCharacter.Add(warM);

            foreach (GameCharacter gc in gameCharacter)
            {
                Console.WriteLine(gc.Play());
            }




        }

    }
}
