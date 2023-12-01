using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Character
    {
        private int _life;
        private string _name;
        private int _hitChance;
        private int _block;
        private int _maxLife;
        

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }
        public int Block
        { get; set; }
        public int MaxLife
        { get; set; }
        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= MaxLife)
                {
                    _life = value;
                }
                else
                {
                    _life = MaxLife;
                }
            }
        }

        public Character(string name, int maxLife, int block, int _hitChance)
        {
            Name = name;
            MaxLife = maxLife;
            Block = block;
            MaxLife = maxLife;
            HitChance = _hitChance;
            

        }
        public override string ToString()
        {
            return string.Format($"");
        }
    }
}
