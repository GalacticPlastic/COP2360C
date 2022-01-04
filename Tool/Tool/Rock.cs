using System;
namespace RockPaperScissors
{
    class Rock : Tool
    {
        // Data Items
        private string _type;
        private int _strength;

        // Constructor
        public Rock()
        {
        }

        public Rock(string rtype, int rstrength)
        {
            _type = rtype;
            _strength = rstrength;
        }

        // Properties (Access Modifiers)
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int Strength
        {
            get { return _strength; }
            set { _strength = value; }
        }
    }
}
