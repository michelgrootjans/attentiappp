using System;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class CustomerTests
    {
        [Test]
        public void customer_met_10_dagen_kan_5_dagen_verlof_nemen()
        {
            var customer = new Customer {VerlofDagenBeschikbaar = 10};
            customer.AddVerlofDagen(5);
        }

        [Test]
        [ExpectedException(typeof (ArgumentException))]
        public void customer_met_5_dagne_kan_GEEN_10_dagen_nemen()
        {
            ICustomer customer = new Customer {VerlofDagenBeschikbaar = 5};
            customer.AddVerlofDagen(10);
        }
    }
}