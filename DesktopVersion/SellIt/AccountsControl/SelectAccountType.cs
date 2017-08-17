using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SellIt
{
    public partial class SelectAccountType : Form
    {
        public SelectAccountType()
        {
            InitializeComponent();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAccounts obj = new AdminAccounts();
            obj.Show();
        }

        private void buttonCashier_Click(object sender, EventArgs e)
        {
            this.Hide();
            CashierAccounts obj = new CashierAccounts();
            obj.Show();
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerAccounts obj = new CustomerAccounts();
            obj.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeAdmin obj = new WelcomeAdmin();
            obj.Show();
        }
    }
}
