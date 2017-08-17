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
    public partial class VatControl : Form
    {
        VatinfoDAO vatinfoDao = new VatinfoDAO();

        public VatControl()
        {
            InitializeComponent();
            loadProducts();
        }

        private void loadProducts()
        {
            dataGridViewVat.DataSource = vatinfoDao.GetVatList().Tables[0];

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            vatinfoDao.InsertItem(new VatinfoDTO(textBoxType.Text, textBoxVat.Text));
            loadProducts();
            makeEmpty();
        }
        private void makeEmpty()
        {
            textBoxType.Text = "";
            textBoxVat.Text = "";
        }
    }
}
