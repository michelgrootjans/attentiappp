using System.Windows.Forms;
using Interfaces;
using Kata;

namespace MvpDemo
{
    public partial class Form1 : Form, ICustomerDetailView
    {
        private readonly ICustomerDetailPresenter presenter;

        public Form1(int customerId)
        {
            InitializeComponent();
            presenter = new CustomerDetailPresenter(this);

            presenter.Init();
        }

        public int GetCustomerId()
        {
            return 5;
        }

        public void SetCustomer(ICustomer customer)
        {
            label1.Text = customer.Id.ToString();
            label2.Text = customer.Name;
        }

        public void SetSaveButtonVisibility(bool isVisible)
        {
            button1.Enabled = isVisible;
        }
    }
}