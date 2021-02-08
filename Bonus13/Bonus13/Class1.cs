using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus13
{
    public class GameCharacter
    {
        public GameCharacter(int intel, int strength, string name)
        {

            Intel = intel;
            Strength = strength;
            Name = name;

        }
        public int Intel { get; }
        public int Strength { get; }
        public string Name { get; }

        virtual public string Play()
        {

            return "Player " + Name + ": has strength level: " + Strength + ": has intelligence level: " + Intel;
        }
    }




    public class MagicUsingCharacter : GameCharacter
    {
        public MagicUsingCharacter(int intel, int strength, string name, int magicalEnergy) : base(intel, strength, name)
        {
            MagicalEnergy = magicalEnergy;
        }
        public int MagicalEnergy { get; set; }
        public override string Play()
        {
            return base.Play() + " has magic energy: " + MagicalEnergy;
        }

    }

    public class Wizard : MagicUsingCharacter
    { 
        public Wizard(int intel, int strength, string name, int magicalEnergy, int spellnumber):base( intel, strength, name, magicalEnergy)
        {
            SpellNumber = spellnumber;
        }
        public int SpellNumber { get; set; }
        public override string Play()
        {
            return base.Play() + " spell number:  " + SpellNumber;
        }

    }

    public class Warrior : GameCharacter
    {
        public Warrior(int intel, int strength, string name, string weapontype) : base(intel, strength, name)
        {
            WeaponType = weapontype;
        }
        public string WeaponType { get; set; }
        public override string Play()
        {
            return base.Play() + " weapon type: " + WeaponType ;
        }

    }
}

