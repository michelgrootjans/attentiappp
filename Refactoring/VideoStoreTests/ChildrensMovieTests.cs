using NUnit.Framework;
using VideoStore;

namespace VideoStoreTests
{
    [TestFixture]
    public class CustomerRentsChildrensMovieTest
    {
        private const string customerName = "Danny Gladines";
        private Customer customer;
        private string expectedStatement;
        private Movie kidsMovie;

        [SetUp]
        public void Setup()
        {
            customer = new Customer(customerName);
            kidsMovie = new Movie("Wall-e", Movie.CHILDRENS); 
            expectedStatement = string.Format("Rental Record for {0}\n", customerName);
        }

        [Test]
        public void ForOneDay_AddsOneCredit()
        {
            customer.AddRental(new Rental(kidsMovie, 1));

            expectedStatement += "\tWall-e\t1,5\n";
            expectedStatement += "Amount owed is 1,5\n";
            expectedStatement += "You earned 1 frequent renter points";
            Assert.That(customer.Statement(), Is.EqualTo(expectedStatement));
        }

        [Test]
        public void ForFourDays_AddsOneCreditForTheFourthDay()
        {
            customer.AddRental(new Rental(kidsMovie, 4));

            expectedStatement += "\tWall-e\t3\n";
            expectedStatement += "Amount owed is 3\n";
            expectedStatement += "You earned 1 frequent renter points";
            Assert.That(customer.Statement(), Is.EqualTo(expectedStatement));
        }

        [Test]
        public void ForFourDays_AddsOneCreditForTheFifthFourthDay()
        {
            customer.AddRental(new Rental(kidsMovie, 5));

            expectedStatement += "\tWall-e\t4,5\n";
            expectedStatement += "Amount owed is 4,5\n";
            expectedStatement += "You earned 1 frequent renter points";
            Assert.That(customer.Statement(), Is.EqualTo(expectedStatement));
        }

    }
}