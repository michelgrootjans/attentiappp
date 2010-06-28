namespace VideoStore
{
    public class Movie
    {
        internal const int REGULAR = 0;
        internal const int NEW_RELEASE = 1;
        internal const int CHILDRENS = 2;

        private IPrice price;

        public Movie(string title, int priceCode)
        {
            Title = title;
            PriceCode = priceCode;
        }

        public string Title { get; private set; }

        private int priceCode;

        public int PriceCode
        {
            get { return priceCode; }
            set
            {
                priceCode = value;
                CreatePrice(value);
            }
        }

        private void CreatePrice(int code)
        {
            switch (code)
            {
                case REGULAR:
                    price = new RegularPrice();
                    break;
                case NEW_RELEASE:
                    price = new NewReleasePrice();
                    break;
                case CHILDRENS:
                    price = new ChildrensPrice();
                    break;
            }
        }

        public double GetCharge(int daysRented)
        {
            return price.GetCharge(daysRented);
        }

        public int GetFrequentRenterPoints(int daysRented)
        {
            return price.GetFrequentRenterPoints(daysRented);
        }
    }

    public class ChildrensPrice : IPrice
    {
        public double GetCharge(int daysRented)
        {
            var thisAmount = 1.5;
            if (daysRented > 3)
                thisAmount += (daysRented - 3)*1.5;
            return thisAmount;
        }

        public int GetFrequentRenterPoints(int daysRented)
        {
            return 1;
        }
    }

    public class NewReleasePrice : IPrice
    {
        public double GetCharge(int daysRented)
        {
            return daysRented*3;
        }

        public int GetFrequentRenterPoints(int daysRented)
        {
            return daysRented == 1
                       ? 1
                       : 2;
        }
    }

    public class RegularPrice : IPrice
    {
        public double GetCharge(int daysRented)
        {
            var thisAmount = 2.0;
            if (daysRented > 2)
                thisAmount += (daysRented - 2)*1.5;
            return thisAmount;
        }

        public int GetFrequentRenterPoints(int daysRented)
        {
            return 1;
        }
    }
}