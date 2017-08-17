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
    public partial class Products : Form
    {
        StockDAO stockDao = new StockDAO();
        string id = "";
        public Products()
        {
            InitializeComponent();
            loadProducts();
            loadType();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeAdmin obj = new WelcomeAdmin();
            obj.Show();
        }

        private void loadProducts()
        {
            dataGridViewProducts.DataSource = stockDao.GetProducts().Tables[0];

        }
        private void loadType()
        {
            DataTable fatchedTable = stockDao.GetTypes().Tables[0];
            string type="";
            foreach (DataRow dr in fatchedTable.Rows)
            {
                type = dr["type"].ToString();
                comboBoxType.Items.Add(type);
         
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //comboBoxType.Text = "Mahesh Chand";
            makeEmpty();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            stockDao.InsertProducts(new StockDTO(textBoxName.Text, comboBoxType.Text, textBoxRestItem.Text, textBoxSellPrice.Text, textBoxPurPrice.Text, textBoxWeight.Text, textBoxBarcode.Text));
            loadProducts();
            makeEmpty();
        }
        private void makeEmpty()
        {
            textBoxName.Text = "";
            comboBoxType.Text = "";
            textBoxRestItem.Text = "";
            textBoxSellPrice.Text = "";
            textBoxPurPrice.Text = "";
            textBoxWeight.Text = "";
            textBoxBarcode.Text = "";
            id = "";
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count == 1)
            {
                int idx = dataGridViewProducts.SelectedRows[0].Index;
                id = dataGridViewProducts.Rows[idx].Cells[0].Value.ToString();
                textBoxName.Text = dataGridViewProducts.Rows[idx].Cells[1].Value.ToString();
                textBoxRestItem.Text = dataGridViewProducts.Rows[idx].Cells[2].Value.ToString();
                textBoxSellPrice.Text = dataGridViewProducts.Rows[idx].Cells[3].Value.ToString();
                textBoxPurPrice.Text = dataGridViewProducts.Rows[idx].Cells[4].Value.ToString();
                comboBoxType.Text = dataGridViewProducts.Rows[idx].Cells[5].Value.ToString();
                textBoxWeight.Text = dataGridViewProducts.Rows[idx].Cells[6].Value.ToString();
                textBoxBarcode.Text = dataGridViewProducts.Rows[idx].Cells[7].Value.ToString();

            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            stockDao.UpdateProducts(new StockDTO(textBoxName.Text, comboBoxType.Text, textBoxRestItem.Text, textBoxSellPrice.Text, textBoxPurPrice.Text, textBoxWeight.Text, textBoxBarcode.Text,id));
            loadProducts();
            makeEmpty();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            stockDao.DeleteProducts(id);
            loadProducts();
            makeEmpty();
        }
    }
}
