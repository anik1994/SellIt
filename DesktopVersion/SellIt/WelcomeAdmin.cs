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
    public partial class WelcomeAdmin : Form
    {
        StockDAO stockDao = new StockDAO();

        public WelcomeAdmin()
        {
            InitializeComponent();
            loadStock();
        }

        private void loadStock()
        {
            dataGridViewStock.DataSource = stockDao.GetProductList().Tables[0];
            dataGridViewOrder.DataSource = stockDao.GetOrders().Tables[0];
        }
        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            PasswordChange obj = new PasswordChange();
            obj.Show();
        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Calculator obj = new Calculator();
            obj.Show();
        }

        private void buttonBarcode_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Barcode obj = new Barcode();
            obj.Show();
        }

        private void buttonSelectAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectAccountType obj = new SelectAccountType();
            obj.Show();
        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectAccountType obj = new SelectAccountType();
            obj.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            VatControl obj = new VatControl();
            obj.Show();
        }
    }
}
