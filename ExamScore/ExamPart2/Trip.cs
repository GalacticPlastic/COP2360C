using System;
namespace ExamPart2
{
    class Trip
    {
        // Data Items
        private DateTime _travelDate;
        private string _destination;
        private int _distanceTraveled;
        private int _gasolineTotalCost;
        private int _gallonsConsumed;

        // Constructor
        public Trip()
        {

        }

        public Trip(DateTime tdate, string dest, int dist, int gas, int gal)
        {
            _travelDate = tdate;
            _destination = dest;
            _distanceTraveled = dist;
            _gasolineTotalCost = gas;
            _gallonsConsumed = gal;
        }

        // Properties (Access Modifiers)
        public DateTime TravelDate
        {
            get { return _travelDate; }
            set { _travelDate = value; }
        }

        public string Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        public int DistanceTraveled
        {
            get { return _distanceTraveled; }
            set { _distanceTraveled = value; }
        }

        public int GasolineTotalCost
        {
            get { return _gasolineTotalCost; }
            set { _gasolineTotalCost = value; }
        }

        public int GallonsConsumed
        {
            get { return _gallonsConsumed; }
            set { _gallonsConsumed = value; }
        }
    }
}
