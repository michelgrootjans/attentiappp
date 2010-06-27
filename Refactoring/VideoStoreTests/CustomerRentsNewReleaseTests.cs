using NUnit.Framework;
using VideoStore;

namespace VideoStoreTests
{
    [TestFixture]
    public class CustomerRentsNewReleaseTests
    {
        private const string customerName = "Danny Gladines";
        private Customer customer;
        private string expectedStatement;
        private Movie newRelease;

        [SetUp]
        public void Setup()
        {
            customer = new Customer(customerName);
            newRelease = new Movie("Harry Potter 7", Movie.NEW_RELEASE);
            expectedStatement = string.Format("Rental Record for {0}\n", customerName);
        }

        [Test]
        public void ForOneDay_AddsOneCredit_AndAddsAPoint()
        {
            customer.AddRental(new Rental(newRelease, 1));

            expectedStatement += "\tHarry Potter 7\t3\n";
            expectedStatement += "Amount owed is 3\n";
            expectedStatement += "You earned 1 frequent renter points";
            Assert.That(customer.Statement(), Is.EqualTo(expectedStatement));
        }

        [Test]
        public void ForTwoDays_AddsOneCreditForTheSecondDay_AndAddsAnExtraPoint()
        {
            customer.AddRental(new Rental(newRelease, 2));

            expectedStatement += "\tHarry Potter 7\t6\n";
            expectedStatement += "Amount owed is 6\n";
            expectedStatement += "You earned 2 frequent renter points";
            Assert.That(customer.Statement(), Is.EqualTo(expectedStatement));
        }

        [Test]
        public void ForThreeDays_AddsAnotherCreditForTheThirdDay_AndAddsNoExtraPoint()
        {
            customer.AddRental(new Rental(newRelease, 3));

            expectedStatement += "\tHarry Potter 7\t9\n";
            expectedStatement += "Amount owed is 9\n";
            expectedStatement += "You earned 2 frequent renter points";
            Assert.That(customer.Statement(), Is.EqualTo(expectedStatement));
        }
    }
}