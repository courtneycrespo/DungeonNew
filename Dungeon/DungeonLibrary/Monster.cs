namespace DungeonLibrary
{
    public class Monster
    {
        private int _minDamage;

        //TODO - Monster types?
        public string Description { get; set; }
        public int MaxDamage { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                _minDamage = value > 0 && value <= MaxDamage ? value : 1;
            }
        }

        public string Name { get; private set; }

        public Monster(string name, int life, int MaxLife, int MinLife, int block,
            int hitChance, string description, int minDamage, int maxDamage)

        {
            Name = name;
            Description = description;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
        }

        public override string ToString()
        {
            return string.Format("{0}\n{1}",
                Name,
                Description);
        }


    }
}
