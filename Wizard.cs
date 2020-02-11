using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1RPG
{
    class Wizard : MagicUsingCharacter
    {
        private int spellNumber;

        public int SpellNumber { get => spellNumber; set => spellNumber = value; }

        public Wizard(string name, int strength, int intelligence, int spellNumber) : base(name, strength, intelligence, spellNumber)
        {
            this.spellNumber = spellNumber;
        }

        public virtual string Play()
        {
            return base.Play() + $", Spell Number: {spellNumber}";
        }

    }
}
