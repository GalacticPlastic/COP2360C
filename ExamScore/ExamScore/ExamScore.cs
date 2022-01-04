using System;

namespace ClassExample
{
    class ExamScore
    {
        // Data Items
        private int _studentId;
        private int _score1;
        private int _score2;
        private int _score3;

        // Constructor
        public ExamScore(int stid, int score1, int score2, int score3)
        {
            _studentId = stid;
            _score1 = score1;
            _score2 = score2;
            _score3 = score3;
        }

        // Properties (Access Modifiers)
        public int StudentId
        {
            get { return _studentId; }
            set { _studentId = value; }
        }

        public int Score1
        {
            get { return _score1; }
            set { _score1 = value; }
        }

        public int Score2
        {
            get { return _score2; }
            set { _score2 = value; }
        }

        public int Score3
        {
            get { return _score3; }
            set { _score3 = value; }
        }
    }
}
