using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1RPG
{
    class MagicUsingCharacter : GameCharacter
    {
        private int magicEnergy;

        public int MagicEnergy { get => magicEnergy; set => magicEnergy = value; }

        public MagicUsingCharacter(string name, int strength, int intelligence,int magicEnergy) : base(name, strength, intelligence)
        {
            this.magicEnergy = magicEnergy;
        }

        public virtual string Play()
        {
            return base.Play() + $", Magic Energy: {magicEnergy}";
        }

    }
}
