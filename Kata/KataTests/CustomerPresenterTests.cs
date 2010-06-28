using Interfaces;
using Kata;
using NUnit.Framework;
using Rhino.Mocks;

namespace KataTests
{
    [TestFixture]
    public class CustomerPresenterTests
    {
        [Test]
        public void TestName()
        {
            var view = MockRepository.GenerateMock<ICustomerDetailView>();
            var customerPresenter = new CustomerDetailPresenter(view);
            view.Stub(v => v.GetCustomerId()).Return(9);

            customerPresenter.Init();

            view.AssertWasCalled(v =>v.SetSaveButtonVisibility(false));
        }

        [Test]
        public void mlkqjsfkljqsdfkljqsdflmj()
        {
            var view = MockRepository.GenerateMock<ICustomerDetailView>();
            var customerPresenter = new CustomerDetailPresenter(view);
            view.Stub(v => v.GetCustomerId()).Return(10);

            customerPresenter.Init();

            view.AssertWasCalled(v =>v.SetSaveButtonVisibility(true));
        }
    }
}