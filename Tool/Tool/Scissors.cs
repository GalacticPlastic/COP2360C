using System;
namespace RockPaperScissors
{
    class Scissors : Tool
    {
        // Data Items
        private string _type;
        private int _strength;

        // Constructor
        public Scissors()
        {
        }

        public Scissors(string stype, int sstrength)
        {
            _type = stype;
            _strength = sstrength;
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
