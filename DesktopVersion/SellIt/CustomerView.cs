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
    public partial class CustomerView : Form
    {
        StockDAO stockDao = new StockDAO();
        public CustomerView()
        {
            InitializeComponent();
            //loadCustomer();
        }

        /*private void loadCustomer()
        {
            dataGridViewCustomer.DataSource = stockDao.GetCustomers().Tables[0];
        }*/
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeCashier obj = new WelcomeCashier();
            obj.Show();
        }
    }
}
