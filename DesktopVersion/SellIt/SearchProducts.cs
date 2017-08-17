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
    public partial class SearchProducts : Form
    {
        StockDAO stockDao = new StockDAO();

        public SearchProducts()
        {
            InitializeComponent();
            loadProducts();
        }
        private void loadProducts()
        {
            dataGridViewProductSearch.DataSource = stockDao.GetProductList().Tables[0];
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string search = "";
            search = textBoxSearch.Text;
            dataGridViewProductSearch.DataSource = stockDao.GetList(search).Tables[0];
        }
    }
}
