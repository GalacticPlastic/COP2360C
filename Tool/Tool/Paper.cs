using System;
namespace RockPaperScissors
{
    class Paper : Tool
    {
        // Data Items
        private string _type;
        private int _strength;

        // Constructor
        public Paper()
        {
        }

        public Paper(string ptype, int pstrength)
        {
            _type = ptype;
            _strength = pstrength;
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
