namespace Models.Generics
{
    //nr de credite actuale si nr maxim posibil

    //value object
    public class Credits
    {
        private const int _maxCredits = 60;
        public static int MAX { get { return _maxCredits; } }

        private int _credits;
        public int Count { get { return _credits; } set { _credits = value; } }

        public Credits()
        {
        }

        public Credits(int credits)
        {
            _credits = credits;
        }
    }
}
