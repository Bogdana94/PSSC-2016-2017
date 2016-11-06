namespace Models.Generics
{
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



        public override string ToString()
        {
            return _credits.ToString();
        }

        public override bool Equals(object obj)
        {
            var credit = (Credits)obj;

            if (credit != null)
            {
                return _credits.Equals(credit._credits);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _credits.GetHashCode();
        }
    }
}
