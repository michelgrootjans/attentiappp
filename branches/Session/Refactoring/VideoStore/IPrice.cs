namespace VideoStore
{
    internal interface IPrice
    {
        double GetCharge(int daysRented);
        int GetFrequentRenterPoints(int daysRented);
    }
}