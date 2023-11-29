using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {
        //Fields - declaring these fields to be able to store information
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;

        //Properties - public gate keepers to access our fields
        public int MaxDamage
        {
            get { return _maxDamage; }//getter
            set { _maxDamage = value; }//setter - rules for accessing private fields
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }
        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }

            }
        }

        //Constructor - tells us how to build a weapon helps us define what a Weapon() is
        public Weapon(string name, int maxDamage, int minDamage, int bonusHitChance, bool isTwoHanded)
        {
            Name = name;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;

        }//we have given a quality to each one of it's properties

        public override string ToString() 
        {
            return string.Format($"{Name}\nDamage: {MinDamage} - {MaxDamage}\nBonusHit: {BonusHitChance}\n " +
                $"Type: {(IsTwoHanded ? "Two Handed" : "One Handed")} ");

        }


    }
}
