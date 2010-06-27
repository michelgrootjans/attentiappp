using NUnit.Framework;
using VideoStore;

namespace VideoStoreTests
{
    [TestFixture]
    public class CustomerRentsRegularMovieTests
    {
        private const string customerName = "Danny Gladines";
        private Customer customer;
        private string expectedStatement;
        private Movie regularMovie;

        [SetUp]
        public void Setup()
        {
            customer = new Customer(customerName);
            regularMovie = new Movie("The dirty dozen", Movie.REGULAR);
            expectedStatement = string.Format("Rental Record for {0}\n", customerName);
        }

        [Test]
        public void ForOneDay_AddsTwoCredits()
        {
            customer.AddRental(new Rental(regularMovie, 1));

            expectedStatement += "\tThe dirty dozen\t2\n";
            expectedStatement += "Amount owed is 2\n";
            expectedStatement += "You earned 1 frequent renter points";
            Assert.That(customer.Statement(), Is.EqualTo(expectedStatement));
        }

        [Test]
        public void ForThreeDays_AddsOneCreditForTheThirdDay()
        {
            customer.AddRental(new Rental(regularMovie, 3));

            expectedStatement += "\tThe dirty dozen\t3,5\n";
            expectedStatement += "Amount owed is 3,5\n";
            expectedStatement += "You earned 1 frequent renter points";
            Assert.That(customer.Statement(), Is.EqualTo(expectedStatement));
        }

        [Test]
        public void ForFourDays_AddsOneCreditForTheFourthDay()
        {
            customer.AddRental(new Rental(regularMovie, 4));

            expectedStatement += "\tThe dirty dozen\t5\n";
            expectedStatement += "Amount owed is 5\n";
            expectedStatement += "You earned 1 frequent renter points";
            Assert.That(customer.Statement(), Is.EqualTo(expectedStatement));
        }
    }
}