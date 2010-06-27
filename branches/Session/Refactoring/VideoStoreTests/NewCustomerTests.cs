using NUnit.Framework;
using VideoStore;

namespace VideoStoreTests
{
    [TestFixture]
    public class CustomerTests
    {
        private const string customerName = "Danny Gladines";
        private Customer customer;

        [SetUp]
        public void Setup()
        {
            customer = new Customer(customerName);
        }

        [Test]
        public void CustomerHasAName()
        {
            Assert.That(customer.Name, Is.EqualTo(customerName));
        }

        [Test]
        public void CustomerHasAnEmptyStatement()
        {
            var expectedStatement = string.Format("Rental Record for {0}\n", customerName);
            expectedStatement += "Amount owed is 0\n";
            expectedStatement += "You earned 0 frequent renter points";
            Assert.That(customer.Statement(), Is.EqualTo(expectedStatement));
        }
    }
}