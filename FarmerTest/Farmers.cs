namespace FarmerTest
{
    public class Farmers
    {
        public int BagsOfFeed { get; private set; }
        private int _feedMultiplier;
        public int FeedMultiplier
        {
            get { return _feedMultiplier; }
        }
        private int _numberOfCows;

        //Constructor
        public Farmers(int numberOfCows, int feedMultiplier)
        {
            _feedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }

        public int NumberOfCows
        {
            get
            {
                return _numberOfCows;
            }
            set
            {
                _numberOfCows = value;
                BagsOfFeed = _numberOfCows * FeedMultiplier;
            }
        }
        
    }
}