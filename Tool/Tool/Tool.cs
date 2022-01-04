using System;
namespace RockPaperScissors
{
    class Tool
    {
        // Data Items
        private string _type;
        private int _strength;

        // Constructor
        public Tool()
        {
        }

        public Tool(string ttype, int tstrength)
        {
            _type = ttype;
            _strength = tstrength;
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
