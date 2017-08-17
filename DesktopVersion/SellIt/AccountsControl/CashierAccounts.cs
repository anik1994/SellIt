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
    public partial class CashierAccounts : Form
    {
        UserinfoDAO userinfoDao = new UserinfoDAO();
        string id = "", password = "";

        public CashierAccounts()
        {
            InitializeComponent();
            loadCashier();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            userinfoDao.AddUser(new UserinfoDTO(textBoxName.Text, textBoxUserName.Text, "123456", "cashier", textBoxAddress.Text, textBoxPhn.Text, Convert.ToInt32(textBoxAge.Text), Convert.ToDouble(textBoxSalary.Text)));
            loadCashier();
            makeEmpty();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            userinfoDao.UpdateUser(new UserinfoDTO(textBoxName.Text, textBoxUserName.Text, password, "cashier", textBoxAddress.Text, textBoxPhn.Text, Convert.ToInt32(textBoxAge.Text), Convert.ToDouble(textBoxSalary.Text), id));
            loadCashier();
            makeEmpty();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            userinfoDao.DeleteUser(id);
            loadCashier();
            makeEmpty();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            makeEmpty();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeAdmin obj = new WelcomeAdmin();
            obj.Show();
        }

        private void loadCashier()
        {
            dataGridViewCashier.DataSource = userinfoDao.GetCashier().Tables[0];
        }

        private void dataGridViewCashier_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCashier.SelectedRows.Count == 1)
            {
                int idx = dataGridViewCashier.SelectedRows[0].Index;
                id = dataGridViewCashier.Rows[idx].Cells[0].Value.ToString();
                textBoxName.Text = dataGridViewCashier.Rows[idx].Cells[1].Value.ToString();
                textBoxUserName.Text = dataGridViewCashier.Rows[idx].Cells[2].Value.ToString();
                password = dataGridViewCashier.Rows[idx].Cells[3].Value.ToString();
                textBoxAge.Text = dataGridViewCashier.Rows[idx].Cells[5].Value.ToString();
                textBoxAddress.Text = dataGridViewCashier.Rows[idx].Cells[6].Value.ToString();
                textBoxPhn.Text = dataGridViewCashier.Rows[idx].Cells[7].Value.ToString();
                textBoxSalary.Text = dataGridViewCashier.Rows[idx].Cells[8].Value.ToString();

            }
        }
        private void makeEmpty()
        {
            //make the text boxes and others empty
            textBoxName.Text = "";
            textBoxUserName.Text = "";
            textBoxAge.Text = "";
            textBoxAddress.Text = "";
            textBoxPhn.Text = "";
            textBoxSalary.Text = "";
            id = "";
            password = "";
        }
    }
}
